namespace DO_Login
{
    using CommonServiceLocator;
    using DO_Login.Core;
    using DO_Login.Models;
    using DO_Login.Views;
    using GalaSoft.MvvmLight.Views;
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        public static ViewModelLocator Locator;
        public static Form AppForm;
        public static INavigationService NavigationService;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppForm = new Form();
            Locator = new ViewModelLocator();
            NavigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            NavigationService.NavigateTo("LoginView");

            Application.Run(AppForm);
        }
    }
}

