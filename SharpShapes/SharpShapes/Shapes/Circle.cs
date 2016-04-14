using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
    public class Circle : Shape, I2Dimensional
    {
        public double area { get; set; } // pi * r ^ 2

        public double radius { get; set; }

        public double calculateArea(double radius)
        {
            return (radius * radius) * Math.PI;
        }

        public Circle() {
            name = "Circle";
            numberOfSides = 1;
        }
    }
}
