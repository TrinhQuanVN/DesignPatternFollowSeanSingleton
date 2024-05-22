using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBroad.ViewModels
{
    public class ProfitViewModel
    {
        public double Profit => 5000;
        public bool IsPositive => Profit > 0;
        public bool IsNegative => Profit < 0;
    }
}
