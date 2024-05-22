using Stategy.Models.AvailableDashBroadStategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Stategy.Models
{
    public class DashBroad
    {
        private int _width;
        private int _height;
        private IAvailableDashBroadStategy _availableDashBroadStategy;

        private int[,] _dashBroad;
        public DashBroad(int width, int height, IAvailableDashBroadStategy availableDashBroadStategy)
        {
            _dashBroad = new int[width, height];
            _width = width;
            _height = height;
            _availableDashBroadStategy = availableDashBroadStategy;
        }
        public bool IsWithinBound(int x, int y) => x < _width && y < _height && x >=0 && y >=0;
        public bool HasValue(DashBroadLocation location) => _dashBroad[location.X, location.Y] >= 0;

        public void Add(int value, DashBroadLocation location)
        {
            if (value < 0 || value >9) 
            {
                throw new ArgumentException("value must greater than 0 and less than 10", nameof(value));
            }
            if (location.X<0 || location.X >9)
            {
                throw new ArgumentException("X must greater than 0 and less than 10", nameof(location));
            }
            if (location.Y < 0 || location.Y > 9)
            {
                throw new ArgumentException("Y must greater than 0 and less than 10", nameof(location));
            }
            var availableLocation = _availableDashBroadStategy.Find(location, this);
            if (availableLocation !=null)
            {
                _dashBroad[location.X, location.Y] = value;
            }
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    builder.Append(_dashBroad[x, y]);

                    builder.Append(' ');
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

    }
}
