using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class Terminal
    {

        public string userInput
        {
            get { return userInput; }
            set
            {
                if (value != "") userInput = value;
            }
        }
        public string LoadMessage { get; set; }
        public Terminal()
        {
            LoadMessage = @"*********************************************************
* * Welcome to Bangazon! Command Line Ordering System * *
*********************************************************
1.Create an account
2.Create a payment option
3.Order a product
4.Complete an order
5.See product popularity
6.Leave Bangazon!
> ";

        }
    }
}
