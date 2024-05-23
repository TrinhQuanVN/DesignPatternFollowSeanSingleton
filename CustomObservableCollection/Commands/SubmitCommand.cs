using CustomObservableCollection.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomObservableCollection.Commands
{
    public class SubmitCommand : ICommand
    {
        private readonly DriveThruViewModel _viewmodel;

        private static int UNIQUE_ORDER_ID = 1;
        public SubmitCommand(DriveThruViewModel viewmodel)
        {
            _viewmodel = viewmodel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
           
        }
    }
}
