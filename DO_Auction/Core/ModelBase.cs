using DO_Login.Interfaces;
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
    public abstract class ModelBase : IViewModel, INotifyPropertyChanged
    {
        // boiler-plate
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNavigatedTo(object nav)
        {
            throw new NotImplementedException();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
