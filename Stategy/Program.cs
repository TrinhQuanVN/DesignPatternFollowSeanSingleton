using Stategy;
using Stategy.Models;
using Stategy.Models.AvailableDashBroadStategy;

var dashBroad = new DashBroad(5, 5, new DepthFirstAvailabelDashBroadStategy());
dashBroad.Add(1, new DashBroadLocation(0, 0));

Console.WriteLine(dashBroad);

var box = new int[3, 3];

//Console.WriteLine(box[0, 0]);
//Console.WriteLine(box[0, 1]);