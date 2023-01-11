using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pie
{
    internal class Pie : Food
    {

        public Pie(string name)
        {
            Name = name;
        }

        public override int GetCost()
        {
            return 300;
        }
    }
}
