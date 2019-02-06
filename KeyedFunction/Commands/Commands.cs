using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeyedFunction.Commands
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _action;
        private bool _canExecute = true;

        public Command(Action action)
        {
            _action = action;
        }

        //public Command(Action action, bool canExecute)
        //{
        //    _action = action;
        //    _canExecute = canExecute;
        //}

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
