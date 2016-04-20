using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.NumberPatterns
{
    public class Prime : Integer
    {
        public List<int> allPrimes { get; set; }
        public Prime()
        {
            initial = 1;
            allPrimes = new List<int>();
        }

        public List<int> createPrimesList()
        {
            for (int i = 3; i < 5; i++) // temp limit
            {
                int max = (int)(Math.Floor(Math.Sqrt(i)));
                bool isPotentiallyPrime = true;
                for (int j = 2; j <= max; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    //var x = i / j;
                    //if (x is int)
                    //{
                    //    isPotentiallyPrime = false;
                    //}    
                }
                Console.ReadLine();
            }
            return allPrimes;
        }
    }
}
