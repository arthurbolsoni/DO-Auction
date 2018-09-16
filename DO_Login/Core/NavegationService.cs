using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_Login.Core
{
    public class NavigationService : INavigationService
    {
        /// <summary>
        /// The key that is returned by the <see cref="CurrentPageKey"/> property
        /// when the current Page is the root page.
        /// </summary>
        public const string RootPageKey = "-- ROOT --";

        /// <summary>
        /// The key that is returned by the <see cref="CurrentPageKey"/> property
        /// when the current Page is not found.
        /// This can be the case when the navigation wasn't managed by this NavigationService,
        /// for example when it is directly triggered in the code behind, and the
        /// NavigationService was not configured for this page type.
        /// </summary>
        public const string UnknownPageKey = "-- UNKNOWN --";

        private readonly Dictionary<string, Type> _pagesByKey = new Dictionary<string, Type>();

        private ViewBase _currentView;
        public ViewBase CurrentView
        {
            get
            {
                return _currentView;
            }

            set
            {
                _currentView = value;
            }
        }


        private Form _app;
        public Form App
        {
            get
            {
                return _app?? (_app= ((Form)Program.AppForm));
            }

            set
            {
                _app = value;
            }
        }

        public bool CanGoBack => true;

        public bool CanGoForward => true;

        public string CurrentPageKey => throw new NotImplementedException();

        public void GoForward()
        {
        }

        public void GoBack()
        {

        }

        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        public NavigationService()
        {


        }

        /// <summary>
        /// Displays a new page corresponding to the given key,
        /// and passes a parameter to the new page.
        /// Make sure to call the <see cref="Configure"/>
        /// method first.
        /// </summary>
        /// <param name="pageKey">The key corresponding to the page
        /// that should be displayed.</param>
        /// <param name="parameter">The parameter that should be passed
        /// to the new page.</param>
        /// <exception cref="ArgumentException">When this method is called for 
        /// a key that has not been configured earlier.</exception>
        public virtual void NavigateTo(string pageKey, object parameter)
        {
            lock (_pagesByKey)
            {
                if (!_pagesByKey.ContainsKey(pageKey))
                {
                    throw new ArgumentException(
                        string.Format(
                            "No such page: {0}. Did you forget to call NavigationService.Configure?",
                            pageKey),
                        "pageKey");
                }

                if (App.Controls.Find(pageKey, true).ToList().Count == 0)
                {
                    Type type = _pagesByKey[pageKey];

                    UserControl newControl = (UserControl)Activator.CreateInstance(type);

                    App.Controls.Add(newControl);
                }

                if(CurrentView != null)
                {
                    Control control = App.Controls.Find(CurrentView.Name, true).ToList().First();
                    if (control != null) control.Hide();
                    CurrentView = null;
                }

                CurrentView = (ViewBase)App.Controls.Find(pageKey, true).ToList().FirstOrDefault();

                if (CurrentView != null)
                {
                    App.AutoSize = true;
                    App.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                    CurrentView.Tag = App;
                    CurrentView.Show();

                    CurrentView.OnNavigatedTo(parameter);
                }
            }
        }

        /// <summary>
        /// Adds a key/page pair to the navigation service.
        /// </summary>
        /// <param name="key">The key that will be used later
        /// in the <see cref="NavigateTo(string)"/> or <see cref="NavigateTo(string, object)"/> methods.</param>
        /// <param name="pageType">The type of the page corresponding to the key.</param>
        public void Configure(string key, Type pageType)
        {
            lock (_pagesByKey)
            {
                if (_pagesByKey.ContainsKey(key))
                {
                    throw new ArgumentException("This key is already used: " + key);
                }

                if (_pagesByKey.Any(p => p.Value == pageType))
                {
                    throw new ArgumentException(
                        "This type is already configured with key " + _pagesByKey.First(p => p.Value == pageType).Key);
                }

                _pagesByKey.Add(
                    key,
                    pageType);
            }
        }
    }
}