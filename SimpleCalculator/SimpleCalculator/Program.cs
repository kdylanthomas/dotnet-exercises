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
                Console.Write("[{0}]> ", stack.idx);
                string userInput = Console.ReadLine();
               

                if (userInput.ToUpper() == "EXIT" || userInput.ToUpper() == "QUIT")
                {
                    Console.WriteLine("bye!");
                    Console.ReadLine();
                    keepGoing = false;
                    break;
                }
                else if (userInput.ToUpper() == "LAST")
                {
                    Console.WriteLine(stack.lastA);
                }
                else if (userInput.ToUpper() == "LASTQ")
                {
                    Console.WriteLine(stack.lastQ);
                }
                else
                {
                    exp.parseExpression(userInput);
                    stack.lastQ = userInput;
                    switch (exp.mathOperator)
                    {
                        case "+":
                            stack.lastA = methods.add(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine("= " + stack.lastA);
                            break;
                        case "-":
                            stack.lastA = methods.subtract(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine("= " + stack.lastA);
                            break;
                        case "*":
                            stack.lastA = methods.multiply(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine("= " + stack.lastA);
                            break;
                        case "/":
                            stack.lastA = methods.divide(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine("= " + stack.lastA);
                            break;
                        case "%":
                            stack.lastA = methods.modulo(exp.firstArgument, exp.secondArgument);
                            Console.WriteLine("= " + stack.lastA);
                            break;
                        case "=": 
                            var kvp = methods.assignVariable(exp.firstArgument, exp.secondArgument);
                            if (!stack.UserConstants.Exists(x => x.Key == kvp.Key))
                            {
                                stack.UserConstants.Add(kvp);
                                Console.WriteLine("saved {0} as {1}", exp.firstArgument, exp.secondArgument);
                            }
                            else Console.WriteLine("This variable cannot be reassigned.");
                            break;
                    }
                    stack.idx++;
                }
            }
        }
    }
}
