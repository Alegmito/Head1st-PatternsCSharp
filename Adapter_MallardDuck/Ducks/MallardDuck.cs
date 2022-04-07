using Strategy_MallardDuck.FlyBehavior;
using Strategy_MallardDuck.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_MallardDuck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new OrdinaryQuack()) { }

        public override void Display()
        {
            Console.WriteLine("This is a mallard Duck");
            base.Display();
        }
    }
}
