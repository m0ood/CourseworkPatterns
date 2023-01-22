using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pizza
{
    abstract class PizzaDecorator :Pizza
    {
        public Pizza pizza;
        public PizzaDecorator(Pizza pizza) : base(pizza.Name)
        {
            this.pizza = pizza;
        }
    }
}
