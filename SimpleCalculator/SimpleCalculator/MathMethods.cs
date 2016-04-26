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

        public double modulo(string x, string y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return a % b;
        }

        public KeyValuePair<char,double> assignVariable(string x, string y)
        {
            char a = Convert.ToChar(x.Trim().ToLower());
            double b = Convert.ToDouble(y);
            return new KeyValuePair<char,double>(a, b);
        }
        public MathMethods()
        {
        }
    }
}
