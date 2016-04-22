using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class MathMethods
    {

        public double add(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return a + b;
        }

        public double subtract(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return a - b;
        }

        public double multiply(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return a * b;
        }

        public double divide(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return a / b;
        }

        public MathMethods()
        {
        }
    }
}
