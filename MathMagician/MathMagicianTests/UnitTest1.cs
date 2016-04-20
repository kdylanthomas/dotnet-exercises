using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.NumberPatterns;

// program should produce Fibonnaci #s, prime #s, or integers, infinitely
// test w/o infinite loop?

namespace MathMagicianTests
{
    [TestClass]
    public class UnitTest1
    {
        //private object result;

        [TestMethod]
        public void ProduceFibonacciNumbers()
        {
            Fibonacci fibs = new Fibonacci();
            var actual = fibs.createFibonacciList();
            CollectionAssert.AreEqual(actual.ToArray(), new int[] {1, 1, 2, 3, 5, 8, 13, 21 });
        }

        //[TestMethod]
        //public void ProducePrimeNumbers()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        printPrime();
        //    }
        //    Assert.AreEqual(result.ToArray, new int[] { 3, 5, 7, 11, 13, 17, 19 });
        //}

        [TestMethod]
        public void ProduceIntegers()
        {
            Integer ints = new Integer();
            var actual = ints.createIntegerList();
            CollectionAssert.AreEqual(actual.ToArray(), new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }


    }
}
