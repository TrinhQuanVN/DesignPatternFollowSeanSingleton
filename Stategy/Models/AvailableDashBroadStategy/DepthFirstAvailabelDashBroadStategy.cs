using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stategy.Models.AvailableDashBroadStategy
{
    public class DepthFirstAvailabelDashBroadStategy : IAvailableDashBroadStategy
    {
        public DashBroadLocation? Find(DashBroadLocation startLocation, DashBroad dashBroad)
        {
            return Find(startLocation, dashBroad, new HashSet<DashBroadLocation>());
        }

        private DashBroadLocation? Find(DashBroadLocation startLocation, DashBroad dashBroad, HashSet<DashBroadLocation> dashBroadLocations)
        {

            if (!dashBroad.IsWithinBound(startLocation.X,startLocation.Y))
            {
                return null;
            }
            if (!dashBroad.HasValue(startLocation))
            {
                return startLocation;
            }

            dashBroadLocations.Add(startLocation);

            var surroundLocations = new List<DashBroadLocation>()
            {
                startLocation.Add(0,-1),
                startLocation.Add(-1,0),
                startLocation.Add(0,1),
                startLocation.Add(1,0),

            };
            foreach (var location in surroundLocations)
            {
                var availableLocation = Find(location, dashBroad, dashBroadLocations);
                if (availableLocation !=null)
                {
                    return availableLocation;
                }
            }

            return null;
        }
    }
}
