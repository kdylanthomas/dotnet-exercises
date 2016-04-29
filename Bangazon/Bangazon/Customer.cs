using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bangazon
{
    class Customer
    {
        //public string Name { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string PostalCode { get; set; }
        //public string PhoneNumber { get; set; }


        public string[] RequiredFields { get; set; }
        public List<string> UserInputs { get; set; }

        public Customer()
        {
            RequiredFields = new[]
            {
                "Enter customer name \n>",
                "Enter street address \n>",
                "Enter city \n>",
                "Enter state \n>",
                "Enter postal code \n>",
                "Enter phone number \n>"
            };
        }

        char[] LettersInName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ParseName(string name)
        {
            bool spaceFound = false;
            LettersInName = name.ToCharArray();
            for (int i = 0; i < LettersInName.Length; i++)
            {
                if (new Regex("[ ]").IsMatch(LettersInName[i].ToString())) spaceFound = true;
                if (spaceFound)
                {
                    this.LastName += LettersInName[i];
                }
                else
                {
                    this.FirstName += LettersInName[i];
                }
            }
        }

    }
}
