using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class MathMethodClass
    {
        [TestMethod]
        public void CanAddTwoNumbers()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            exp.fullExpression = "2 + 4";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(6, methods.add(exp.firstArgument, exp.secondArgument));
        }

        [TestMethod]
        public void CanSubtractTwoNumbers()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            exp.fullExpression = "8 - 5";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(3, methods.subtract(exp.firstArgument, exp.secondArgument));
        }

        [TestMethod]
        public void CanMultiplyTwoNumbers()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            exp.fullExpression = "8 * 3";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(24, methods.multiply(exp.firstArgument, exp.secondArgument));
        }

        [TestMethod]
        public void CanDivideTwoNumbers()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            exp.fullExpression = "9 / 3";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(3, methods.divide(exp.firstArgument, exp.secondArgument));
        }

        [TestMethod]
        public void CanInterpretNegativeNumbers()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            exp.fullExpression = "3 - 6";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(-3, methods.subtract(exp.firstArgument, exp.secondArgument));
        }
        
    }
}
