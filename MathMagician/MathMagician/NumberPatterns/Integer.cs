using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MathMagician.NumberPatterns
{
    public class Integer
    {
        public int initial { get; set; } // starting value for num list

        public List<int> allIntegers { get; set; }

        public Integer()
        {
            initial = 1;
            allIntegers = new List<int>();
        }

        public List<int> createIntegerList()
        {
            int i = initial;
            bool keepGoing = true;

            while (keepGoing == true)
            {
                if (i > 100000) // temporary in place of ReadKey
                {
                    keepGoing = false;
                    break;
                }
                allIntegers.Add(i);
                i++;
            }

            foreach (int item in allIntegers)
            {
                Console.WriteLine(item);
                Thread.Sleep(500);
            }
            Console.ReadLine();
            return allIntegers;
        }

    }
}
