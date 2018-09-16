using System;
using System.ComponentModel;
using System.Windows.Forms;
using DO_Login.Interfaces;
using GalaSoft.MvvmLight.Views;

namespace DO_Login.Core
{
    public partial class ViewBase : UserControl, IView
    {
        public virtual void OnNavigatedTo(object nav)
        {
            string fullName = $"DO_Login.ViewModels.{GetType().Name.Replace("View", "ViewModel")}";
            Type viewModelType = Type.GetType(fullName);

            ViewModelBase ViewModel = (ViewModelBase)CommonServiceLocator.ServiceLocator.Current.GetInstance(viewModelType);
            ViewModel.OnNavigatedTo(nav);
        }

        public virtual void PerformBinding()
        {
            throw new NotImplementedException();
        }
    }
}
