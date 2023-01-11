using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pie
{
    abstract class PieDecorator : Pie
    {
        public Pie pie;
        public PieDecorator(string name, Pie pie) : base(name)
        {
            this.pie = pie;
        }
    }
}
