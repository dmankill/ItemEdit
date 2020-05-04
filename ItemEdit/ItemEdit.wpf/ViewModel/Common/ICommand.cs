using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEdit.wpf.ViewModel.Common
{
    interface ICommand
    {
        event EventHandler CanExecuteChanged;
       bool CanExecute(object parameter);
       void Execute(object parameter);
    }
}
