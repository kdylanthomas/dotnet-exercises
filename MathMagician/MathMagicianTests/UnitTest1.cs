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

        [TestMethod] // pass
        public void ProduceFibonacciNumbers()
        {
            Fibonacci fibs = new Fibonacci();
            var actual = fibs.createFibonacciList();
            CollectionAssert.AreEqual(actual.ToArray(), new int[] {1, 1, 2, 3, 5, 8, 13, 21 });
        }

        [TestMethod] // fail
        public void ProducePrimeNumbers()
        {
            Prime primes = new Prime();
            var actual = primes.createPrimesList();
            CollectionAssert.AreEqual(actual.ToArray(), new int[] { 3, 5, 7, 11, 13, 17, 19 });
        }

        [TestMethod] // pass
        public void ProduceIntegers()
        {
            Integer ints = new Integer();
            var actual = ints.createIntegerList();
            CollectionAssert.AreEqual(actual.ToArray(), new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }


    }
}
