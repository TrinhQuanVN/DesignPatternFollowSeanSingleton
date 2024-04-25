using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observation
{
    internal class OrderItemView : IDisposable
    {
        private OrderItemViewModel _viewModel;

        public OrderItemView(OrderItemViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            Print();
        }

        public void ClickButton1()
        {
            _viewModel.IncreateQuantityCommand.Execute(null);
        }

        private void Print()
        {
            Console.WriteLine($"{_viewModel.Description} x {_viewModel.Quantity}");
        }

        public void Dispose()
        {
            _viewModel.PropertyChanged -= ViewModel_PropertyChanged;
        }
    }
}
