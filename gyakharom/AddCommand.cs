using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace gyakharom
{
    public class AddCommand : ICommand
    {
        private DataModel _model;

        public AddCommand(DataModel model)
        { 
            _model = model;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_model.CurrentName) &&
                   !string.IsNullOrEmpty(_model.CurrentType) &&
                   !string.IsNullOrEmpty(_model.CurrentAge) ? true : false;
        }

        public void Execute(object? parameter)
        {
            _model.AddAnimalToCollection();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
