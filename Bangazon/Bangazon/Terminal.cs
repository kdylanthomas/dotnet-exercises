using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class Terminal
    {
        SqlData sqlData = new SqlData();

        public void ShowMenu()
        {
            Console.Write(
@"*********************************************************
* * Welcome to Bangazon! Command Line Ordering System * *
*********************************************************
1.Create an account
2.Create a payment option
3.Order a product
4.Complete an order
5.See product popularity
6.Leave Bangazon!
> ");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    CreateNewCustomer();
                    break;
                default:
                    break;
            }
        }

        public void CreateNewCustomer()
        {
            Customer cust = new Customer();
            cust.IdCustomer = 5;
            Console.WriteLine("Enter first name \n>");
            cust.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name \n>");
            cust.LastName = Console.ReadLine();
            Console.WriteLine("Enter street address \n>");
            cust.StreetAddress = Console.ReadLine();
            Console.WriteLine("Enter city \n>");
            cust.City = Console.ReadLine();
            Console.WriteLine("Enter state \n>");
            cust.State = Console.ReadLine();
            Console.WriteLine("Enter postal code \n>");
            cust.PostalCode = Console.ReadLine();
            Console.WriteLine("Enter phone number \n>");
            cust.PhoneNumber = Console.ReadLine();

            sqlData.CreateCustomer(cust);
        }
    }
}
