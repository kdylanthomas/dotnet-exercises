﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class OrderProducts
    {
        public int IdOrderProducts { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomerOrder { get; set; }
        public int IdCustomer { get; set; }
    }
}
