using Strategy_MallardDuck.FlyBehavior;
using Strategy_MallardDuck.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_MallardDuck.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new Squeak()) { }
        public override void Display()
        {
            Console.WriteLine("This is an oridinary rubber Duck");
            base.Display();
        }
    }
}
