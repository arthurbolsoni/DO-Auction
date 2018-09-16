using DO_Login.Core;
using DO_Login.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public RelayCommand LoginCommand => _loginCommand = new RelayCommand(() => newLogin(SID, Server + ".darkorbit.com"));

        private RelayCommand _WBCommand;
        public RelayCommand WBCommand => _WBCommand = new RelayCommand(async () => await NavegationAsync("http://www.darkorbit.com"));

        public void newLogin(String SID, String server)
        {
            DOApiService api = null;
            try
            {
                if (SID == null) new Exception();
                if (server == null) new Exception();

                api = new DOApiService(SID, server);
            }
            catch
            {
                //loginError();
                return;
            }

            goAuction(api);
        }

        public override void OnNavigatedTo(Object nav)
        {
            base.OnNavigatedTo(nav);
        }

        private void goAuction(DOApiService api)
        {
            Program.NavigationService.NavigateTo("AuctionView", api);
        }

        public async Task<String> NavegationAsync(String url)
        {
            wb = new WebBrowser();
            wb.ScriptErrorsSuppressed = true;
            TaskCompletionSource<String> tcsDocument = null;

            wb.DocumentCompleted += (s, e) =>
            {
                if (wb.Url.ToString().Contains("Error=99")) new Exception();

                if (wb.Url.ToString().Contains("&prc=100"))
                {
                    tcsDocument.SetResult(wb.DocumentText);
                    newLogin(DOApiService.getSIDByHtml(wb.DocumentText), wb.Url.Host);
                    wb = null;
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
