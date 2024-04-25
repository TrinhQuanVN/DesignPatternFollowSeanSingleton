using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Observation
{
    public class OrderItemViewModel : INotifyPropertyChanged
    {
        public string Description { get; }

        public OrderItemViewModel(string description)
        {
            Description = description;
            IncreateQuantityCommand = new IncreateOrderItemQuatityCommand(this);
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged(nameof(Quantity)); }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public ICommand IncreateQuantityCommand { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
