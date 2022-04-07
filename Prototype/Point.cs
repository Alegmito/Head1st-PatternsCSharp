using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(in int x, in int y)
        {
            X = x;
            Y = y;
        }
    }
}
