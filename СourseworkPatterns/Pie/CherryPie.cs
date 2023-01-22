using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pie
{
    internal class CherryPie : PieDecorator
    {
        public CherryPie(Pie pie)
        : base(pie)
        {
           Name += ", с вишней";
        }

        public override int GetCost()
        {
            return pie.GetCost() + 100;
        }
    }
}
