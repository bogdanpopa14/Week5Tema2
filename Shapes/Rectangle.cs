using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle:Shape
    {
        public Rectangle(double w,double h):base(h,w)
        { }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
