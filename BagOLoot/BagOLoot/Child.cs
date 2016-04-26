using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOLoot
{
    public class Child
    {
        // needs name
        public string Name { get; set; }
        // needs list of toys
        public List<string> Toys { get; set; }
        // bool toysDelivered
        public bool ToysDelivered { get; set; }

        public Child(string name)
        {
            Name = name;
            Toys = new List<string>();
            ToysDelivered = false;
        }
    }
}
