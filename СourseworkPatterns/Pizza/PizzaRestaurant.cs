using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pizza
{
    internal class PizzaRestaurant:Restaurant
    {
        public PizzaRestaurant(string name) : base(name)
        { }

        public override Pizza Create()
        {
            return new Pizza("Пицца с сыром");
        }
    }
}
