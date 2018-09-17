using DO_Login.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_Login.Core
{
    public class Navigation : INavigation
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

        private readonly List<Type> _pagesByKey = new List<Type>();

        private ViewBase _currentView;
        public ViewBase CurrentView { get => _currentView; set => _currentView = value; }

        private int _currentIndex;
        public int CurrentIndex { get => _currentIndex; set => _currentIndex = value; }

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

        public bool CanGoBack()
        {
            return App.Controls.Count == 2 ? true : false;
        }

        public bool CanGoForward => true;

        public void GoBack()
        {
            CurrentIndex = App.Controls.Count -2;
            IEnumerable<Control> controls = App.Controls.Cast<Control>();
            Control control = controls.ToList()[CurrentIndex];

            CurrentView.Hide();
            CurrentView = (ViewBase)control;

            if (CurrentView != null)
            {
                App.AutoSize = true;
                App.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                CurrentView.Tag = App;
                CurrentView.Show();
            }
        }

        public void GoForward()
        {

        }

        public virtual void NavigateTo(Type pageType, object parameter)
        {
            //App.Controls.Count();

            CurrentIndex = App.Controls.Count -1;

            Type type = pageType;
            UserControl newControl = (UserControl)Activator.CreateInstance(type);
            App.Controls.Add(newControl);

            if (CurrentView != null)
            {
                Control control = App.Controls.Find(CurrentView.Name, true).ToList().First();
                //if (control != null) control.Hide();
                if (control != null) App.Controls.Remove(control);
                App.Refresh();
            }

            CurrentView = (ViewBase)App.Controls.Find(pageType.Name, true).ToList().FirstOrDefault();

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
}