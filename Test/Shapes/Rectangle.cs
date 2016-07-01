using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public static int NumberOfInstances;


        public override double Area()
        {
            var area = length * width;
            return area;
        }
        public override double GetPerimeter()
        {
            var perim = 2*length + 2*width;
            return perim;
        }
        public Rectangle()
        {
            NumberOfInstances++;
        }

        public Rectangle(double length, double width)
        {
            NumberOfInstances++;
            this.length = length;
            this.width = width;

        }

        public override string ToString()
        {
            var perimetru = 2 * length + 2 * width;
            return String.Format("Petrimetru: {0}", perimetru);


        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > length)
                    Console.WriteLine("Dreptunghi nu e valid");
                else
                    width = value;
            }
        }

        public override ShapeTypeEnum ShapeType
        {
            get
            {
                
                return ShapeTypeEnum.Rectangle;
               
            }
        }
    }
}
