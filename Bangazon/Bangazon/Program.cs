using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {

            Terminal term = new Terminal();
            Console.Write(term.LoadMessage); // initial user prompts
            var UserSelection = Console.ReadLine();
            Console.WriteLine("\nUserSelection is {0}", UserSelection);
            Console.ReadLine();

            switch (UserSelection)
            {
                case "1":
                    Customer cust = new Customer();
                    List<string> NewCustomerFields = new List<string>();
                    for (int i = 0; i < cust.RequiredFields.Length; i++)
                    {
                        Console.WriteLine(cust.RequiredFields[i]);
                        string userInput = Console.ReadLine();
                        //if (i == 0) cust.ParseName(userInput);
                        // ^^ not sure if this should happen here or before query
                        NewCustomerFields.Add(userInput);
                    }
                    break;
                default:
                    break;
            }

            // follow prompts to create a user account...needs to collect arguments in a list
        }
    }
}
