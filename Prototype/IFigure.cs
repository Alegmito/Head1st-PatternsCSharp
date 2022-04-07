using System;

namespace Prototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
