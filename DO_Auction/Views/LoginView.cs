using Bindery;
using DO_Login.Core;
using DO_Login.Services;
using DO_Login.ViewModels;
using DO_Login.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_Login.Views
{
    public partial class LoginView : ViewBase
    {
        public LoginView()
        {
            InitializeComponent();
            PerformBinding();
        }

        public override void OnNavigatedTo(Object nav)
        {
            base.OnNavigatedTo(nav);
        }

        public override void PerformBinding()
        {
            LoginViewModel ViewModel = Program.Locator.LoginViewModel;

            var binder = Create.Binder(ViewModel);

            // Two-way binding
            binder.Control(tbSID).Property(c => c.Text).Bind(vm => vm.SID);
            // Two-way binding
            binder.Control(tbServer).Property(c => c.Text).Bind(vm => vm.Server);
            // Two-way binding
            binder.Control(tbLogin).Property(c => c.Text).Bind(vm => vm.Login);
            // Two-way binding
            binder.Control(tbSenha).Property(c => c.Text).Bind(vm => vm.Password);

            binder.Control(button1).OnClick().Execute(ViewModel.WBCommand);
            binder.Control(button2).OnClick(ViewModel.LoginCommand);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.NavigationService.GoForward();
        }
    }
}
