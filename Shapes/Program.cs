using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape tr = new Triangle(2, 3);
            Shape dr = new Rectangle(5, 7);
            Shape pt = new Square(2);
            List<Shape> fig = new List<Shape>();
            fig.Add(tr);
            fig.Add(dr);
            fig.Add(pt);
            foreach (var item in fig)
            {
                Console.WriteLine(item.CalculateSurface()); 
            }
            Console.ReadLine();
           
        }
    }
}
