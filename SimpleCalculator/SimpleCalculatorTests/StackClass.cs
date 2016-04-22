using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StackClass
    {
        [TestMethod]
        public void SetLastQ()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            Stack stack = new Stack();

            exp.fullExpression = "3 + 8";
            stack.lastQ = exp.fullExpression;
            Assert.AreEqual(stack.lastQ, "3 + 8");

        }

        [TestMethod]
        public void SetLastA()
        {
            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            Stack stack = new Stack();

            exp.fullExpression = "4 + 6";
            exp.parseExpression(exp.fullExpression);
            stack.lastA = methods.add(exp.firstArgument, exp.secondArgument);
            Assert.AreEqual(10, stack.lastA);
            
        }
    }
}
