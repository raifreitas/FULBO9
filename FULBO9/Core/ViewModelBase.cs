using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FULBO9.Core
{/**
     * Esta es la clase "Base" para todos tus ViewModels.
     * Implementa la interfaz INotifyPropertyChanged.
     * Su trabajo es avisar a la Vista (View) cuando un dato cambia.
     */
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
