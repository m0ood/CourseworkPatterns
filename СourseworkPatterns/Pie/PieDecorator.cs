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
        public PieDecorator(Pie pie) : base(pie.Name)
        {
            this.pie = pie;
        }
    }
}
