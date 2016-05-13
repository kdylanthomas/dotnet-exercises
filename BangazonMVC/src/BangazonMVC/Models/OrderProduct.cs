using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonMVC.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomerOrder { get; set; }
        public int IdCustomer { get; set; }
    }
}
