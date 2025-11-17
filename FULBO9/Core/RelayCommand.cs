using System;
using System.Windows.Input;

namespace FULBO9.Core
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;

        // ARREGLO: El tipo 'Func<bool>' ahora puede ser nulo
        private readonly Func<bool>? _canExecute;

        // ARREGLO: Se añade '?' para coincidir con la interfaz moderna
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // ARREGLO: Se añade '?' al parámetro 'canExecute'
        public RelayCommand(Action execute, Func<bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        // ARREGLO: Se añade '?' al parámetro 'parameter'
        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute();

        // ARREGLO: Se añade '?' al parámetro 'parameter'
        public void Execute(object? parameter) => _execute();
    }
}