using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public abstract double Area();
        public virtual double GetPerimeter()
        {
            return 0;
        }
        public abstract ShapeTypeEnum ShapeType
        {
            get;
        }


    }

    public enum ShapeTypeEnum
    {
        Rectangle,
        Triangle,
        Circle
    };

   
}
