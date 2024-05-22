using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stategy.Models
{
    public class DashBroadLocation
    {
        public DashBroadLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public DashBroadLocation Add(int x, int y)
        {
            return new DashBroadLocation(X + x, Y + y);
        }
    }
}
