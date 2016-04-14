using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes.Shapes;

namespace SharpShapesTests
{
    [TestClass]
    public class UnitTest1
    
    {
        [TestMethod] // Are new shapes instances of shapes?
        public void TestShapeType()
        {
            Shape simple = new Shape();
            Assert.IsTrue(simple.GetType() == typeof(Shape));
        }

        [TestMethod]
        public void TestRhombusArea() // Does rhombus calculate area correctly?
        {
           Square x = new Square();
            Assert.AreEqual(25, x.calculateArea(5));

        }

        [TestMethod]
        public void TestCircleArea() // Does circle calculate area correctly?
        {
            Circle x = new Circle();
            Assert.AreEqual(4 * Math.PI, x.calculateArea(2));

        }

        [TestMethod]
        public void TestSquareArea() // Does square calculate area correctly?
        {
            Square x = new Square();
            Assert.AreEqual(36, x.calculateArea(6));

        }

        [TestMethod]
        public void TestCubeVolume() // Does cube calculate volume correctly?
        {
            Cube x = new Cube();
            Assert.AreEqual(27, x.calculateVolume(3));

        }
        [TestMethod]
        public void TestCylinderVolume() // Does cylinder calculate volume correctly?
        {
            Cylinder x = new Cylinder();
            Assert.AreEqual(20 * Math.PI, x.calculateVolume(2, 5));

        }

        [TestMethod]
        public void SquareHasFourSides()
        {
            Square x = new Square();
            Assert.IsTrue(x.numberOfSides == 4);

        }

        [TestMethod]
        public void SquareHasWidth()
        {
            Square x = new Square();
            Assert.IsTrue(x.GetType().GetProperty("width") != null);

        }

        [TestMethod]
        public void RhombusHasFourSides()
        {
            Rhombus x = new Rhombus();
            Assert.IsTrue(x.numberOfSides == 4);

        }

        [TestMethod]
        public void RhombusHasWidth()
        {
            Rhombus x = new Rhombus();
            Assert.IsTrue(x.GetType().GetProperty("width") != null);

        }

        [TestMethod]
        public void CircleHasOneSide()
        {
            Circle x = new Circle();
            Assert.IsTrue(x.numberOfSides == 1);

        }

        [TestMethod]
        public void CircleHasRadius()
        {
            Circle x = new Circle();
            Assert.IsTrue(x.GetType().GetProperty("radius") != null);

        }

        [TestMethod]
        public void CubeHasSixSides()
        {
            Cube x = new Cube();
            Assert.IsTrue(x.numberOfSides == 6);

        }

        [TestMethod]
        public void CubeHasWidth()
        {
            Cube x = new Cube();
            Assert.IsTrue(x.GetType().GetProperty("width") != null);

        }

        [TestMethod]
        public void CylinderHasThreeSides()
        {
            Cylinder x = new Cylinder();
            Assert.IsTrue(x.numberOfSides == 3);

        }

        [TestMethod]
        public void CylinderHasHeight()
        {
            Cylinder x = new Cylinder();
            Assert.IsTrue(x.GetType().GetProperty("height") != null);

        }

        [TestMethod]
        public void CylinderHasRadius()
        {
            Cylinder x = new Cylinder();
            Assert.IsTrue(x.GetType().GetProperty("radius") != null);

        }
    }
}
