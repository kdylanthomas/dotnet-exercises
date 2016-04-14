using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes.Shapes
{
    public class Cylinder : Shape, I3Dimensional
    {
        public double volume { get; set; }

        public double radius { get; set; }
        public double height { get; set; }

        public double calculateVolume(double radius, double height)
        {
            return ((radius * radius) * Math.PI) * height;
        }
        public Cylinder() {
            name = "Cylinder";
            numberOfSides = 3;
        }
    }
}
