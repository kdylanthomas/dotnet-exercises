using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
    public class Cube : Shape, I3Dimensional
    {
        public double volume { get; set; }

        public bool hasEqualSides = true;

        public double width { get; set; }

        public double calculateVolume(double width)
        {
            return width * width * width;
        }

        public Cube() { // constructor
            name = "Cube";
            numberOfSides = 6;
        }

    }
}
