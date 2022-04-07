using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Circle : IFigure
    {
        public Point Point { get; set; }
        public float Radius { get; set; }
        public Circle( in int r, in int x = 0, in int y = 0)
        {
            Point = new Point(x, y);
            Radius = r;
        }

        public Circle(in Circle other)
        {
            Point = new Point(other.Point.X, other.Point.Y);
            Radius = other.Radius;
        }
            
        public IFigure Clone()
        {
            return new Circle(this);
        }

        public void GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
