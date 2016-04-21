using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMagician.NumberPatterns;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Math Magician. What would you like me to do?");
            Console.WriteLine("Choose integers, primes, or fibonaccis.");
            string userInput = Console.ReadLine();

            Console.WriteLine("Ok, I'm going to help produce {0}. \nPress CTRL + C to exit.", userInput);

            switch (userInput)
            {
                case "integers":
                    Integer ints = new Integer();
                    ints.createIntegerList();
                    break;
                case "primes":
                    Prime primes = new Prime();
                    primes.createPrimesList();
                    break;
                case "fibonaccis":
                    Fibonacci fibs = new Fibonacci();
                    fibs.createFibonacciList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

    }
}
