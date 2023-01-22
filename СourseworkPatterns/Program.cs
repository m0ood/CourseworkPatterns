using СourseworkPatterns;
using СourseworkPatterns.Pie;
using СourseworkPatterns.Pizza;

Restaurant restaurant = new PieRestaurant("The best pies");
Food pie = restaurant.Create();
pie = new StrawberryPie((Pie)pie);
pie = new CherryPie((Pie)pie);
Console.WriteLine(pie.GetOrder()+ ". В ресторане: "+ restaurant.Name);

restaurant = new PizzaRestaurant("The best pizza");
Food pizza = restaurant.Create();
pizza = new MushroomPizza((Pizza)pizza);
pizza = new PepperoniPizza((Pizza)pizza);
Console.WriteLine(pizza.GetOrder() + ". В ресторане: " + restaurant.Name);

//without Decorator
Console.WriteLine("Without Decorator");
restaurant = new PieRestaurant("The best pies");
pie = restaurant.Create();
pie.Name+= ", с вишней";
pie.Name+= ", с клубникой";
Console.WriteLine("Состав заказ: " + pie.Name + " стоимостью: " + (pie.GetCost()+250) + ". В ресторане: " + restaurant.Name);

restaurant = new PizzaRestaurant("The best pizza");
pizza = restaurant.Create();
pizza.Name += ", с пепперони";
pizza.Name += ", с грибами";
Console.WriteLine("Состав заказ: " + pizza.Name + " стоимостью: " + (pizza.GetCost() + 150) + ". В ресторане: " + restaurant.Name);

//without Factory Method
Console.WriteLine("Without Factory Method");
string restaurantName = "The best pies";
pie = new Pie("Пирог");
pie.Name += ", с вишней";
pie.Name += ", с клубникой";
Console.WriteLine("Состав заказ: " + pie.Name + " стоимостью: " + (pie.GetCost() + 250) + ". В ресторане: " + restaurantName);

restaurantName = "The best pizza";
pizza = new Pizza("Пицца с сыром");
pie.Name += ", с пепперони";
pie.Name += ", с грибами";
Console.WriteLine("Состав заказ: " + pie.Name + " стоимостью: " + (pie.GetCost() + 250) + ". В ресторане: " + restaurantName);