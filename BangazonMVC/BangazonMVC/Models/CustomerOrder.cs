using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonMVC.Models
{
    public class CustomerOrder
    {
        public int IdCustomerOrder { get; set; }
        public string OrderNumber { get; set; }
        public string DateCreated { get; set; }
        public int IdCustomer { get; set; }
        public string PaymentType { get; set; }
        public string Shipping { get; set; }
        public int IdPaymentOption { get; set; }
    }
}