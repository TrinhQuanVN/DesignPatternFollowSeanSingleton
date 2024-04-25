using Observation;
var vm = new OrderItemViewModel("shoe");
var v = new OrderItemView(vm);

v.ClickButton1();
v.ClickButton1();
v.ClickButton1();
v.ClickButton1();

v.Dispose();

v.ClickButton1();