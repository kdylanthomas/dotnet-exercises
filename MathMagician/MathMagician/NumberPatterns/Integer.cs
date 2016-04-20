using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.NumberPatterns
{
    public class Integer
    {
        public int initial { get; set; } // starting value for num list
        public int increment { get; set; } // increment by how many? 
        public List<int> allIntegers { get; set; }

        public Integer()
        {
            initial = 1;
            increment = 1;
            allIntegers = new List<int>(); // initialize list w/ first number
        }

        // method needed:
        // if current + increment is an integer, add that number to the list

        public List<int> createIntegerList()
        {
            int i = initial;
            bool keepGoing = true;

            while (keepGoing == true)
            {
                if (i > 10) // temporary in place of ReadKey
                {
                    keepGoing = false;
                    break;
                }
                Console.WriteLine("allIntegers is {0}", allIntegers);
                Console.WriteLine("i is {0}", i);
                allIntegers.Add(i);
                i += increment;
            }
            return allIntegers;
        }

    }
}
