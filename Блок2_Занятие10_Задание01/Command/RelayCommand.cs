using System.Windows.Input;

namespace Блок2_Занятие10_Задание01.Command
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object?> _executeDelegate;
        private readonly Func<object?, bool> _canExecuteDelegate;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter) => _canExecuteDelegate?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => _executeDelegate?.Invoke(parameter);

        public RelayCommand(Action<object?> executeDelegate, Func<object?, bool> canExecuteDelegate = null)
        {
            _canExecuteDelegate = canExecuteDelegate;
            _executeDelegate = executeDelegate ?? throw new ArgumentNullException($"Элемент имеет null - {nameof(_executeDelegate)}");
        }
    }
}
