
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_Login.Interfaces
{
    /// <summary>
    /// Interface enforces base requirements of all 'ViewModel' types.
    /// </summary>
    public interface IViewModel
    {
        // Should raise property changed events upon internal properties updating.
        void OnNavigatedTo(Object nav);
    }
}
