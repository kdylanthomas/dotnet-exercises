using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonMVC.Models
{
    public class OrderProduct
    {
        public int IdOrderProducts { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomerOrder { get; set; }
        public int IdCustomer { get; set; }
    }
}