using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            
            bool keepGoing = true;
            while (keepGoing)
            {
                Expressions exp = new Expressions();
                MathMethods methods = new MathMethods();
                Console.WriteLine("[{0}]>", stack.idx);
                stack.lastQ = Console.ReadLine(); 
                var x = exp.parseExpression(stack.lastQ);
                Console.WriteLine("\n=");
                if (stack.lastQ.ToUpper() == "EXIT")
                {
                    Console.WriteLine("bye!");
                    Console.ReadLine();
                    keepGoing = false;
                    break;
                }
                else
                {
                    switch (exp.mathOperator)
                    {
                        case "+":
                            stack.lastA = methods.add(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine(stack.lastA);
                            break;
                        case "-":
                            stack.lastA = methods.subtract(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine(stack.lastA);
                            break;
                        case "*":
                            stack.lastA = methods.multiply(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine(stack.lastA);
                            break;
                        case "/":
                            stack.lastA = methods.divide(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine(stack.lastA);
                            break;
                    }
                    stack.idx++;
                }
            }
        }
    }
}
