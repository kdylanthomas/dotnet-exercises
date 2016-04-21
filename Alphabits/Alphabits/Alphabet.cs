using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    public class Alphabet
    {
        public char[] expectedLetters { get; set; }
        public List<char> userLetters { get; set; }

        public void addLetter(char x)
        {
            userLetters.Add(x);
        }

        public int checkLength()
        {
            return userLetters.Count;
        }

        public Alphabet()
        {
            expectedLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            userLetters = new List<char>();
        }
    }
}
