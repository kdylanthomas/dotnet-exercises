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
            for (int i = 2; i < 20; i++) // temporary limit
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
                            // Console.WriteLine("{0} isn't a prime number.", i, j);
                            break;
                        }
                        else if (hasRemainder == true)
                        {
                            isPotentiallyPrime = true;
                            if (j == max)
                            {
                                // Console.WriteLine("{0} is a prime number!", i);
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
                        // Console.WriteLine("{0} isn't a prime number.", i);
                    }
                    else
                    {
                        isPotentiallyPrime = true;
                        allPrimes.Add(i);
                        // Console.WriteLine("{0} is a prime number!", i);
                    }
                }

            }
            foreach (int item in allPrimes)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            return allPrimes;
        }
    }
}
