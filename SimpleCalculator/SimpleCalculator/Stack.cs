using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        //Using Test Driven Development, create a Stack class that can hold the last evaluated expression(for lastq) and the last answer returned(for last). Also, modify your class from chunk 2 to appropriatly handle the last and lastq commands.

        //Ensure your Stack class can easily set the lastq and last(you can name your properties whatever you want)
        //Prove your class from Chunk 2 can properly handle the lastq and last commands.

        public string lastQ { get; set; }
        public double lastA { get; set; }
        public int idx { get; set; }
        public Stack()
        {
            idx = 0;
        }
    }
}
