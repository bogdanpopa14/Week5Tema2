using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        protected double Width;
        protected double Height;
        public Shape(double h,double w)
        {
            this.Height = h;
            this.Width = w;
        }
        public abstract double CalculateSurface();

    }
}
