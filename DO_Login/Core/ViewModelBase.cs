using DO_Login.Interfaces;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DO_Login.Core
{
    /// <summary>
    /// Base/Parent of all ViewModel type classes.
    /// </summary>
    public abstract class ViewModelBase : GalaSoft.MvvmLight.ViewModelBase, IViewModel
    {
        protected readonly INavigationService NavigationService;

        protected ViewModelBase()
        {

        }

        public virtual void OnNavigatedTo(Object nav)
        {
            var a = "aaaaa";
        }
    }
}
