using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pizza
{
    internal class MushroomPizza : PizzaDecorator
    {
        public MushroomPizza(Pizza pizza)
        : base(pizza.Name + ", с грибами", pizza)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 50;
        }
    }
}
