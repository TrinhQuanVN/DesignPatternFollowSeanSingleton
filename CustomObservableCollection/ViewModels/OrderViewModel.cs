using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomObservableCollection.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel(int id, string name, DateTime dateCreated)
        {
            Id = id;
            Name = name;
            DateCreated = dateCreated;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; }
    }
}
