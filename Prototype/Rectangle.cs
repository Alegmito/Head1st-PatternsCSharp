using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Rectangle: IFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(in int width, in int height)
        {
            Width = width;
            Height = height;
        }
        public IFigure Clone()
        {
            return new Rectangle(Width,Height);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rectangle has width: {Width} and Height: {Height}");
        }
    }
}
