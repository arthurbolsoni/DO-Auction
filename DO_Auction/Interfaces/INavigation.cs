using DO_Login.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_Login.Interfaces
{
    //
    // Summary:
    //     An interface defining how navigation between pages should be performed in various
    //     frameworks such as Windows, Windows Phone, Android, iOS etc.
    public interface INavigation
    {
        ViewBase CurrentView { get; }
        void GoBack();
        void GoForward();
        void NavigateTo(Type pageType, object parameter);
    }
}