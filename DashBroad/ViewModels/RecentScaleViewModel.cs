using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBroad.ViewModels
{
    public class RecentScaleViewModel
    {
        private readonly IEnumerable<ScaleViewModel> _scale;

        public RecentScaleViewModel(IEnumerable<ScaleViewModel> scale)
        {
            _scale = new List<ScaleViewModel>
            {
                new ScaleViewModel("Car",20000),
                new ScaleViewModel("Phone",1000),
                new ScaleViewModel("Ship",1000_000),
            };
        }

        public IEnumerable<ScaleViewModel> RecentScale => _scale;
    }
}
