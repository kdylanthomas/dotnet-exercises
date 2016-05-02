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
                case "2":
                    AddPaymentOption();
                    break;
                case "3":
                    OrderProducts();
                    break;
                default:
                    break;
            }
        }

        public void CreateNewCustomer()
        {
            var allCustomers = sqlData.GetCustomers();
            var count = allCustomers.Last().IdCustomer;
            Console.WriteLine(count);
            Console.ReadLine();
            Customer cust = new Customer();
            cust.IdCustomer = count + 1;
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

        public void AddPaymentOption()
        {
            Console.WriteLine("Which customer?");
            var allCustomers = sqlData.GetCustomers();
            foreach (var cust in allCustomers)
            {
                Console.WriteLine(cust.IdCustomer + ". " + cust.FirstName + " " + cust.LastName);
            }
            Console.WriteLine(">");
            PaymentOption po = new PaymentOption();
            var id = Console.ReadLine();
            po.IdCustomer = Convert.ToInt32(id);
            Console.Write("Enter payment type(e.g.AmEx, Visa, Checking) \n>");
            po.Name = Console.ReadLine();
            Console.Write("Enter account number \n>");
            po.AccountNumber = Console.ReadLine();

            sqlData.CreatePaymentOption(po);
        }

        public void OrderProducts()
        {
            var products = sqlData.GetProducts();
            var valueForExit = products.Last().IdProduct + 1;
            int? userInput = null;
            while (userInput != valueForExit)
            {
                Console.WriteLine("Choose a product:");
                foreach (var p in products)
                {
                    Console.WriteLine(p.IdProduct + ". " + p.Name);
                }
                Console.Write("... \n" + valueForExit + ". Return to main menu \n");
                var stringInput = Console.ReadLine();
                userInput = Convert.ToInt32(stringInput);
            }
        }
    }
}
