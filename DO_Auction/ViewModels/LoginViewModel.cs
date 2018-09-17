using DO_Login.Core;
using DO_Login.Services;
using DO_Login.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_Login.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private WebBrowser wb;

        private String _SID;
        public String SID { get => _SID; set { _SID = value; RaisePropertyChanged(); } }

        private String _server;
        public String Server { get => _server; set { _server = value; RaisePropertyChanged(); } }

        private String _login;
        public String Login { get => _login; set { _login = value; RaisePropertyChanged(); } }

        private String _password;
        public String Password { get => _password; set { _password = value; RaisePropertyChanged(); } }

        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand => _loginCommand = new RelayCommand(() => newLoginAsync(SID, Server + ".darkorbit.com"));

        private RelayCommand _WBCommand;
        public RelayCommand WBCommand => _WBCommand = new RelayCommand(async () => await NavegationAsync("http://www.darkorbit.com"));

        private bool _isLoading;
        public bool IsLoading { get => _isLoading; set { _isLoading = value; RaisePropertyChanged(); } }

        private String _error;
        public String Error { get => _error; set { _error = value; RaisePropertyChanged(); } }

        public async void newLoginAsync(String SID, String server)
        {
            DOApiService api = null;
            try
            {
                if (SID == null) new Exception();
                if (server == null) new Exception();

                await Task.Run(() =>
                {
                    api = new DOApiService(SID, server);
                });

                goAuction(api);
            }
            catch
            {
                //loginError();
                IsLoading = false;
                return;
            }
        }

        public override void OnNavigatedTo(Object nav)
        {
            base.OnNavigatedTo(nav);
        }

        private void goAuction(DOApiService api)
        {
            IsLoading = true;
            Program.NavigationService.NavigateTo(typeof(AuctionView), api);
        }

        public async Task<String> NavegationAsync(String url)
        {
            IsLoading = true;

            wb = new WebBrowser();
            wb.ScriptErrorsSuppressed = true;
            TaskCompletionSource<String> tcsDocument = null;

            wb.DocumentCompleted += (s, e) =>
            {
                if (wb.Url.ToString().Contains("Error=99")) new Exception();

                if (wb.Url.ToString().Contains("&prc=100"))
                {
                    tcsDocument.SetResult(wb.DocumentText);
                    newLoginAsync(DOApiService.getSIDByHtml(wb.DocumentText), wb.Url.Host);
                    wb = null;
                    return;
                }

                if (wb.Url.ToString().Contains("www.darkorbit.com"))
                {
                    wb.Document.GetElementById("bgcdw_login_form_username").InnerText = Login;
                    wb.Document.GetElementById("bgcdw_login_form_password").InnerText = Password;

                    foreach (HtmlElement HtmlElement1 in wb.Document.Body.All)
                    {
                        if (HtmlElement1.GetAttribute("className") == "bgcdw_button bgcdw_login_form_login")
                        {
                            HtmlElement1.InvokeMember("click");
                        }
                    }
                }
            };

            tcsDocument = new TaskCompletionSource<String>();
            wb.Navigate(new Uri(url, UriKind.Absolute));

            return await tcsDocument.Task;
        }
    }
}
