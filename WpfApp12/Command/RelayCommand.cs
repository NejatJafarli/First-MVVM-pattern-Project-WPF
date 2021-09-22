using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp12.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object> _execute { get; set; }
        private Predicate<object> _CanExecute { get; set; }

        public RelayCommand(Action<object> execute,Predicate<object> CanExecute=null)
        {

            if (execute is null) throw new NullReferenceException("Exetcute Null");

            _execute = execute;

            _CanExecute = CanExecute;

        }
        public bool CanExecute(object? parameter)
        {
            return _CanExecute is null?true:_CanExecute(parameter);

        }

        public void Execute(object? parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
