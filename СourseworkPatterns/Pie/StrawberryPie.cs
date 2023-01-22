using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns.Pie
{
    internal class StrawberryPie: PieDecorator
    {
        public StrawberryPie(Pie pie)
        : base(pie)
        {
            Name += ", с клубникой";
        }

        public override int GetCost()
        {
            return pie.GetCost() + 150;
        }
    }
}
