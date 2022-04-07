using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_MallardDuck.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't Fly");
        }
    }
}
