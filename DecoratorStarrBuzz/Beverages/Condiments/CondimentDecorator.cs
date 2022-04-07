using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarrBuzz.Beverages.Condiments
{
    abstract class CondimentDecorator: Beverage
    {
        public Beverage Beverage { get; set; }
        public CondimentDecorator (string name, float cost, Beverage beverage) 
            : base (name, cost)
        {
            Beverage = beverage;
        }

        public override float GetCost()
        {
            float cost = Cost;
            CondimentDecorator? current = Beverage as CondimentDecorator;

            while(current != null)
            {
                cost += current.Cost;

                if (current.Beverage is CondimentDecorator)
                    cost += current.Beverage.Cost;

                current = current.Beverage as CondimentDecorator;
                
            }

            cost += current.Cost;
            return cost;
        }

    }
}
