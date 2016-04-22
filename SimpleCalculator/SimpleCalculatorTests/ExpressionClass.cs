using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ExpressionClass
    {
        [TestMethod]
        public void ExtractFirstArgument()
        {
            Expressions exp = new Expressions();
            exp.fullExpression = "14+2";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(exp.firstArgument, "14");
        }

        [TestMethod]
        public void ExtractSecondArgument()
        {
            Expressions exp = new Expressions();
            exp.fullExpression = "14+2";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(exp.secondArgument, "2");
        }

        [TestMethod]
        public void ExtractMathOperator()
        {
            Expressions exp = new Expressions();
            exp.fullExpression = "14+2";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(exp.mathOperator, "+");
        }

        [TestMethod]
        public void DisallowInvalidMathExpressions()
        {
            Expressions exp = new Expressions();
            exp.fullExpression = "-20";
            try
            {
                exp.parseExpression(exp.fullExpression);
                Assert.Fail();
            }
            catch (Exception) {
            }
        }

        [TestMethod]
        public void ExtractionWorksWithSpaces()
        {
            Expressions exp = new Expressions();
            exp.fullExpression = "8 + 5";
            exp.parseExpression(exp.fullExpression);
            Assert.AreEqual(exp.firstArgument, "8 ");
        }


    }
}
