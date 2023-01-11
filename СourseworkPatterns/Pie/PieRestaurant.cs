using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pie
{
    internal class PieRestaurant:Restaurant
    {
        public PieRestaurant(string name) : base(name)
        { }

        public override Pie Create()
        {
            return new Pie("Пирог");
        }
    }
}
