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