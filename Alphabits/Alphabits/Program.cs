using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            Alphabet alphabet = new Alphabet();
            bool keepGoing = true;

            Console.WriteLine("Your challenge is to type each letter of the alphabet in order. Start typing to begin.");

            var interpretInput = new Action(() =>
            {
                char input = collectUserInput();
                int idx = alphabet.checkLength();

                if (alphabet.expectedLetters[idx] == input)
                {
                    alphabet.addLetter(input);
                    string response = String.Format("\n{0} letters entered so far. Keep going!", alphabet.checkLength());
                    Console.WriteLine(response);
                    if (alphabet.checkLength() == 26)
                    {
                        response = String.Format("\nYou completed the challenge!");
                        Console.WriteLine(response);
                        Console.ReadLine();
                        keepGoing = false;
                    }

                }
                else if (Array.IndexOf(alphabet.expectedLetters, input) == -1)
                {
                    string response = String.Format("\n{0} is not a letter.", input);
                    Console.WriteLine(response);
                }
                else if (alphabet.userLetters.IndexOf(input) > -1)
                {
                    string response = String.Format("\nYou already entered this letter!");
                    Console.WriteLine(response);
                }
                else
                {
                    string response = String.Format("\nThat isn't the next letter.");
                    Console.WriteLine(response);
                }
            });

            while (keepGoing == true) // keep prompting user until whole alphabet has been entered
            {
                interpretInput();
            }
        }

        static char collectUserInput() // return letter user typed as a char
        {
            var newLetter = Console.ReadKey();
            return newLetter.KeyChar;
        }

    }
}
