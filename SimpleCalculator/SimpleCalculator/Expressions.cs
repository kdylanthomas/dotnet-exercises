using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expressions
    {
        public string fullExpression { get; set; }
        public string firstArgument { get; set; }
        public string secondArgument { get; set; }
        public string mathOperator {get; set;}

        char[] splitExp { get; set; }

        public char[] parseExpression(string exp)
        {
            splitExp = exp.ToCharArray();
            mathOperator = null;
            // loop through array of characters in full expression
            // push numbers into first argument until operator
            // push numbers into second argument after operator
            for (int i = 0; i < splitExp.Length; i++)
            {
                if (new Regex("[0-9 ]").IsMatch(splitExp[i].ToString()) && mathOperator == null)
                {
                    firstArgument += splitExp[i];
                }
                else if (new Regex("[0-9 ]").IsMatch(splitExp[i].ToString()) && mathOperator != null)
                {
                    secondArgument += splitExp[i];
                }
                else if (new Regex("[+*-/=%]").IsMatch(splitExp[i].ToString()))
                {
                    if (firstArgument == null) throw new System.Exception();
                    else
                    {
                        mathOperator = splitExp[i].ToString();
                    }
                }
            }
            return splitExp;
        }

        public Expressions()
        {
        }
    }
}
