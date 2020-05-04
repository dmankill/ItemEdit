using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ControlzEx.Standard;

namespace ItemEdit.wpf.ViewModel.Common
{
    public class BaseCommand : ICommand
    {
        protected Func<object, bool> _canExecute;
        private Action<object> _execute;

        public BaseCommand(Action<object> execute) : this(execute, null)
        {
        }

        public BaseCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        public bool CanExecute(object param)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(param);
        }

        public void Execute(object param)
        {
            if (_execute != null && CanExecute(param))
            {
                _execute(param);
            }
        }
    }
}