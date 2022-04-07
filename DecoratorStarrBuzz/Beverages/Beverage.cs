using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarrBuzz.Beverages
{
    public class Beverage
    {
        public string Name { get; private set; }
        public float Cost { get; private set; }
        protected Beverage(string name, float cost) 
        {
            Name = name; 
            Cost = cost;
        }

        public virtual float GetCost()
        {
            return Cost;
        }
    }
}
