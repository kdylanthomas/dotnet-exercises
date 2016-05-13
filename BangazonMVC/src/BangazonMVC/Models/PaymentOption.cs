using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonMVC.Models
{
    public class PaymentOption
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
    }
}
