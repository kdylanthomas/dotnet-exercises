using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpShapes.Shapes;

namespace SharpShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize instances of each shape at beginning
            Square square = new Square();
            Circle circle = new Circle();
            Rhombus rhombus = new Rhombus();
            Cube cube = new Cube();
            Cylinder cylinder = new Cylinder();

            // prompt user to choose shape; store shape choice as string
            Console.Write("Select a shape: Circle, Square, Rhombus, Cube, Cylinder ");

            string userShapeChoice = Console.ReadLine();

            switch (userShapeChoice)
            {
                case "Square":
                    Console.WriteLine("Enter the width of the square: ");
                    string squareWidth = Console.ReadLine();
                    square.width = Convert.ToDouble(squareWidth);
                    square.area = square.calculateArea(square.width);
                    Console.WriteLine("The area of your square is {0}. Your square has {1} sides.", square.area, square.numberOfSides);
                    break;
                case "Circle":
                    Console.WriteLine("Enter the width of the circle: ");
                    string circleRadius = Console.ReadLine();
                    circle.radius = Convert.ToDouble(circleRadius);
                    circle.area = circle.calculateArea(circle.radius);
                    Console.WriteLine("The area of your circle is {0}. Your circle has {1} sides.", circle.area, circle.numberOfSides);
                    break;
                case "Rhombus":
                    Console.WriteLine("Enter the width of the rhombus: ");
                    string rhombusWidth = Console.ReadLine();
                    rhombus.width = Convert.ToDouble(rhombusWidth);
                    rhombus.area = rhombus.calculateArea(rhombus.width);
                    Console.WriteLine("The area of your rhombus is {0}. Your rhombus has {1} sides.", rhombus.area, rhombus.numberOfSides);
                    break;
                case "Cube":
                    Console.WriteLine("Enter the width of the cube: ");
                    string cubeWidth = Console.ReadLine();
                    cube.width = Convert.ToDouble(cubeWidth);
                    cube.volume = cube.calculateVolume(cube.width);
                    Console.WriteLine("The volume of your cube is {0}. Your cube has {1} sides.", cube.volume, cube.numberOfSides);
                    break;
                case "Cylinder":
                    Console.WriteLine("Enter the radius of the cylinder: ");
                    string cylinderRadius = Console.ReadLine();
                    cylinder.radius = Convert.ToDouble(cylinderRadius);
                    Console.WriteLine("Enter the height of the cylinder: ");
                    string cylinderHeight = Console.ReadLine();
                    cylinder.height = Convert.ToDouble(cylinderHeight);
                    cylinder.volume = cylinder.calculateVolume(cylinder.radius, cylinder.height);
                    Console.WriteLine("The volume of your cylinder is {0}. Your cylinder has {1} sides.", cylinder.volume, cylinder.numberOfSides);
                    break;
                default: throw new ArgumentOutOfRangeException();
            }

            Console.ReadLine();
        }


 
    }
}