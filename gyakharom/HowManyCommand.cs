using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace gyakharom
{
    public class HowManyCommand : ICommand
    {
        private DataModel _model;
        public HowManyCommand(DataModel datamodel) 
        {
            _model = datamodel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public async void Execute(object? parameter)
        {
            int count = _model.Animals.Count(x => x.Name.StartsWith('A'));
            _model.HowManyA = count.ToString();
            await _model.mainPage.DisplayHowManyA();
        }
    }
}
