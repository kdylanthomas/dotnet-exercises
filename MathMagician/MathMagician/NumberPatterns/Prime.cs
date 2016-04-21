using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathMagician.NumberPatterns
{
    public class Prime : Integer
    {
        public List<int> allPrimes { get; set; }
        public Prime()
        {
            initial = 2; // start testing with 2; 1 doesn't count as prime number
            allPrimes = new List<int>();
        }

        public List<int> createPrimesList()
        {

            for (int i = 2; i < 100000; i++) // temporary limit
            {
                int max = (int)(Math.Floor(Math.Sqrt(i)));
                bool isPotentiallyPrime = true;
                if (max > 2)
                {
                    for (int j = 2; j <= max; j++)
                    {
                        double x = (double)i / (double)j;
                        bool hasRemainder = (x - Math.Round(x) != 0) ? true : false;

                        if (hasRemainder == false)
                        {
                            isPotentiallyPrime = false;
                            break;
                        }
                        else
                        {
                            isPotentiallyPrime = true;
                            if (j == max)
                            {
                                allPrimes.Add(i);
                            }
                        }
                    }
                }
                else
                {
                    if (i % 2 == 0 && i != 2)
                    {
                        isPotentiallyPrime = false;
                    }
                    else
                    {
                        isPotentiallyPrime = true;
                        allPrimes.Add(i);
                    }
                }

            }
            foreach (int item in allPrimes)
            {
                Console.WriteLine(item);
                Thread.Sleep(500);
            }

            Console.ReadLine();
            return allPrimes;
        }
    }
}
