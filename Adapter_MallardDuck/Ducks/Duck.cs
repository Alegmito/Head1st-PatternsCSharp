using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_MallardDuck.FlyBehavior;
using Strategy_MallardDuck.QuackBehavior;

namespace Strategy_MallardDuck.Ducks
{
    public class Duck
    {
        public IFlyBehavior FlyBehavior { get; private set; }
        public IQuackBehavior QuackBehavior { get; private set; }

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public void Swim()
        {
            Console.WriteLine("Swimming");
        }

        public virtual void Display() 
        {
            this.Swim();
            FlyBehavior.Fly();
            QuackBehavior.Quack();
        }
    }
}
