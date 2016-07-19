using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kant.Wpf.Toolkit.Mvvm
{
    public abstract class ViewModelBase : ObservableObject
    {
        protected ICommand GetCommand(ICommand c, RelayCommand command)
        {
            if (c == null)
            {
                c = command;
            }

            return c;
        }

        protected ICommand GetCommand<T>(ICommand c, RelayCommand<T> command)
        {
            if (c == null)
            {
                c = command;
            }

            return c;
        }
    }
}
