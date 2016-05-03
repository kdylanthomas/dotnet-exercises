﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class Terminal
    {
        SqlData sqlData = new SqlData();

        List<int> Cart = new List<int>(); // initialize a cart with 0 items

        public void ShowMenu()
        {
            Console.Write(
@"
*********************************************************
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
                case "4":
                    CompleteOrder();
                    break;
                default:
                    break;
            }
        }

        public void ShowCustomerList()
        {
            Console.WriteLine("Which customer?");
            var allCustomers = sqlData.GetCustomers();
            foreach (var cust in allCustomers)
            {
                Console.WriteLine(cust.IdCustomer + ". " + cust.FirstName + " " + cust.LastName);
            }
            Console.WriteLine(">");
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
            ShowCustomerList();
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

                if (userInput != valueForExit) Cart.Add((int)userInput);
            }

            if (userInput == valueForExit)
            {
                ShowMenu();
            }
        }

        public void CompleteOrder()
        {
            if (Cart.Count == 0)
            {
                Console.WriteLine("Please add some products to your order first. Press any key to return to main menu.");
                var goBack = Console.ReadKey();
                if (goBack != null) ShowMenu();
            }
            else
            {
                double total = 0;
                // get back cost of products for each Idproduct in cart
                foreach (var item in Cart)
                {
                    if (item != 6)
                    {
                        var products = sqlData.GetSingleProduct(item);
                        var price = Convert.ToDouble(products[0].Price);
                        total += price;
                    }

                }
                Console.Write("Your total is " + total + ". Ready to check out? \n[Y/N] >");
                var readyToCheckout = Console.ReadLine();
                if (readyToCheckout.ToUpper() == "N") ShowMenu();
                else if (readyToCheckout.ToUpper() == "Y") // only allow checkout on "Y"
                {
                    // choose a customer
                    CustomerOrder co = new CustomerOrder();
                    ShowCustomerList();
                    var stringId = Console.ReadLine();
                    var id = Convert.ToInt32(stringId);

                    // get payment options
                    var paymentOptionsForCust = sqlData.GetPaymentOptions(id);
                    foreach (var option in paymentOptionsForCust)
                    {
                        Console.WriteLine(option.IdPaymentOption + ". " + option.Name);
                    }
                    var stringSelectedPayment = Console.ReadLine();
                    var selectedPayment = Convert.ToInt32(stringSelectedPayment);

                    // get orders so far
                    int orderId = 1;
                    var currentOrders = sqlData.GetCustomerOrders();
                    if (currentOrders.Count != 0) orderId = currentOrders.Last().IdCustomerOrder + 1;

                    co.IdCustomerOrder = orderId;
                    co.IdPaymentOption = selectedPayment;
                    co.IdCustomer = id;
                    co.OrderNumber = "arbitrary string";
                    co.DateCreated = "5/1/2016";
                    co.PaymentType = "Credit/Debit";
                    co.Shipping = "USPS";

                    sqlData.CreateCustomerOrder(co); // create order
                    // add each order product to OrderProducts
                    foreach (var item in Cart)
                    {
                        var currProducts = sqlData.GetOrderProducts();
                        var count = 0;
                        if (currProducts.Count != 0) count = currProducts.Last().IdOrderProducts;
                        OrderProducts op = new OrderProducts();
                        op.IdOrderProducts = count + 1;
                        op.IdProduct = item;
                        op.IdCustomerOrder = orderId;
                        sqlData.CreateOrderProduct(op);
                    }
                    
                    Console.WriteLine("Your order is complete! Press any key to return to main menu.");
                    var x = Console.ReadLine();
                    if (x != null) ShowMenu();
                }
            }
        }
    }
}
