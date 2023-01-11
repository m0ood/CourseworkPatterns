using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseworkPatterns
{
    abstract class Restaurant
    {
        public string Name { get; set; }

        public Restaurant(string name)
        {
            Name = name;
        }
        // фабричный метод
        abstract public Food Create();
    }
}
