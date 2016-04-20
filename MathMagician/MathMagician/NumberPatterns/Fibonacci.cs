using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.NumberPatterns
{
   public class Fibonacci : Integer
    {
        public List<int> allFibonaccis { get; set; }

        public Fibonacci()
        {
            initial = 1;
            allFibonaccis = new List<int>();
        }

        public List<int> createFibonacciList()
        {
            bool keepGoing = true;
            int i = initial;
            allFibonaccis.Add(initial);
            allFibonaccis.Add(initial);

            while (keepGoing == true)
            {
                if (i > 20) // temporary way to manage limit until I implement readkey
                {
                    keepGoing = false;
                    break;
                }
                var currFibArr = allFibonaccis.ToArray();
                int currLength = currFibArr.Length;
                int firstNumber = currFibArr[currLength - 2];
                int secondNumber = currFibArr[currLength - 1];
                i = firstNumber + secondNumber;
                allFibonaccis.Add(i);
            }
            return allFibonaccis;
        }

    }
}
