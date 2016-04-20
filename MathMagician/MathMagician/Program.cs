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

            switch (userInput)
            {
                case "integers":
                    break;
                case "primes":
                    break;
                case "fibonaccis":
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        
            Console.WriteLine("Press any key to exit.");
            var quit = Console.ReadKey();
            if (quit != null) Environment.Exit(0);

            //Integer ints = new Integer();
            //ints.createIntegerList();
            //Fibonacci fibs = new Fibonacci();
            //fibs.createFibonacciList();
            //Prime primes = new Prime();
            //primes.createPrimesList();
            // Main should take user input and determine
            // which method to run based on input
        }

    }
}
