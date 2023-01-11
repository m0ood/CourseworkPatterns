using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pizza
{
    internal class Pizza : Food
    {
        public Pizza(string name)
        {
            this.Name = name;
        }
        public override int GetCost()
        {
            return 200;
        }
    }
}
