using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns
{
    public abstract class Food
    {
        public string? Name { get; protected set; }
        public abstract int GetCost();
        public  string GetOrder()
        {
            return "Состав заказ: "+this.Name + " стоимостью: " + GetCost();
        }
    }
}
