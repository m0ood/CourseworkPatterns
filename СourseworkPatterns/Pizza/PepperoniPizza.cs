using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pizza
{
    internal class PepperoniPizza : PizzaDecorator
    {
        public PepperoniPizza(Pizza pizza)
        : base(pizza)
        {
            Name += ", с пиперине";
        }

        public override int GetCost()
        {
            return pizza.GetCost() + 100;
        }
    }
}
