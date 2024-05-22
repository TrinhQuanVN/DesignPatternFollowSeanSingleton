using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBroad.ViewModels
{
    public class DashbroadViewModel
    {
        public DashbroadViewModel(CostViewModel costViewModel, ProfitViewModel profitViewModel, RecentScaleViewModel recentScaleViewModel, RevenueViewModel revenueViewModel)
        {
            CostViewModel = costViewModel;
            ProfitViewModel = profitViewModel;
            RecentScaleViewModel = recentScaleViewModel;
            RevenueViewModel = revenueViewModel;
        }

        public CostViewModel CostViewModel  { get; set; }
        public ProfitViewModel ProfitViewModel { get; set; }
        public RecentScaleViewModel RecentScaleViewModel { get; set; }
        public RevenueViewModel RevenueViewModel { get; set; }
    }
}
