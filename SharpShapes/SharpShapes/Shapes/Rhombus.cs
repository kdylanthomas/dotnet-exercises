using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
    public class Rhombus : Shape, I2Dimensional
    {
        public double area { get; set; }

        public bool hasEqualSides = true;

        public double width { get; set; }

        public double calculateArea(double width)
        {
            return width * width;
        }

        public Rhombus () {
            name = "Rhombus";
            numberOfSides = 4;
        }

    }
}
