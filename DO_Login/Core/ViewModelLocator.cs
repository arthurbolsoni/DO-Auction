using CommonServiceLocator;
using DO_Login.ViewModels;
using DO_Login.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_Login.Core
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var nav = new NavigationService();

            nav.Configure("AuctionView", typeof(AuctionView));
            nav.Configure("LoginView", typeof(LoginView));

            SimpleIoc.Default.Register<INavigationService>(() => nav);
            SimpleIoc.Default.Register<AuctionViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
        }

        public AuctionViewModel AuctionViewModel => ServiceLocator.Current.GetInstance<AuctionViewModel>();
        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();
    }
}
