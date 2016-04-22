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
                        case "=":
                            Console.WriteLine(exp.mathOperator);
                            break;
                    }
                    stack.idx++;
                }
            }
        }
    }
}
