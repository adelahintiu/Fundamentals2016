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
            Rectangle rectangle = new Rectangle(20, 10);
            //Rectangle rectangle1 = new Rectangle(30, 20);
            //Console.WriteLine(rectangle);
            //rectangle.Length = 30;
            //rectangle.Width = 40;
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine(rectangle);
            Console.WriteLine(rectangle.ShapeType);

            //Console.WriteLine(Rectangle.NumberOfInstances);

        }
    }
}
