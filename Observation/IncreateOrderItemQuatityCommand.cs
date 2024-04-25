using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Observation
{
    internal class IncreateOrderItemQuatityCommand : ICommand
    {
        public IncreateOrderItemQuatityCommand(OrderItemViewModel orderItemViewModel)
        {
            _viewModel = orderItemViewModel;
        }

        private OrderItemViewModel _viewModel { get; }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _viewModel.Quantity++;
        }
    }
}
