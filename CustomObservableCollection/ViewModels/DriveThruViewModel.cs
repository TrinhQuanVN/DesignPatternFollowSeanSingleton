using CustomObservableCollection.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomObservableCollection.ViewModels
{
    public class DriveThruViewModel : INotifyPropertyChanged
    {
        private readonly ObservableCollection<string> _items;
        private readonly ObservationQueue<OrderViewModel> _orders;

        public IEnumerable<OrderViewModel> Orders => _orders;
        public IEnumerable<string> Items => _items;

        public event PropertyChangedEventHandler? PropertyChanged;

        private string _selectedItem;

        public string SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(nameof(SelectedItem)); }
        }
        public DriveThruViewModel()
        {
            _items = new ObservableCollection<string>();
            _orders = new ObservationQueue<OrderViewModel>();
            _items.Add("Chicken");
            _items.Add("Humberger");
            _items.Add("Chinese food");

            SubmitCommand = new SubmitCommand(this);
            GiveCommand = new GiveCommand(this);
        }
        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
        public ICommand SubmitCommand { get; }
        public ICommand GiveCommand { get; }

        public void SubmitOrder(OrderViewModel item)
        {
            _orders.Enqueue(item);
        }
        public void GiveOrder()
        {
            if (_orders.Count>0)
            {
                _orders.TryDequeue(out OrderViewModel order);
            }
        }

    }
}
