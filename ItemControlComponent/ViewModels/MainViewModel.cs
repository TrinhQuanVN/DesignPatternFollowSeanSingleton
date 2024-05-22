using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemControlComponent.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ProductViewModel> _products;
        public IEnumerable<ProductViewModel> ProductViewModel => _products;

        public MainViewModel()
        {
            _products = new ObservableCollection<ProductViewModel>()
            {
                new ProductViewModel("T-Shirt", "A beautiful blue t-shirt.", 29.99),
                new ProductViewModel("Sweatpants", "The greatest gray sweatpants.", 19.99),
                new ProductViewModel("Shoes", "Some radical red shoes.", 179.99),
                new ProductViewModel("Socks", "Just regular socks.", 4.99),
                new ProductViewModel("Shorts", "A pair of shorts that you can use to wear around in, play sports, or record YouTube videos.", 19.99)
            };
        }
    }
}
