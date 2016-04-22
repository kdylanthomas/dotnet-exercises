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

            Expressions exp = new Expressions();
            MathMethods methods = new MathMethods();
            var x = exp.parseExpression("4 - 2");
            Console.WriteLine("\n=");
            Console.WriteLine("operator is {0}", exp.mathOperator);
            switch (exp.mathOperator)
            {
                case "+":
                    Console.WriteLine(methods.add(exp.firstArgument, exp.secondArgument));
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine(methods.subtract(exp.firstArgument, exp.secondArgument));
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine(methods.multiply(exp.firstArgument, exp.secondArgument));
                    Console.ReadLine();
                    break;
                case "/":
                    Console.WriteLine(methods.divide(exp.firstArgument, exp.secondArgument));
                    Console.ReadLine();
                    break;
            }
        }
    }
}
