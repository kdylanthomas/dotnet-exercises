using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOLoot
{
    public class Bag
    {
        // needs Add method
        public void Add(Child child, string toy)
        {
            child.Toys.Add(toy);
        }

        // needs Remove method
        public void Remove(Child child, string toy)
        {
            if (child.Toys.Contains(toy)) child.Toys.Remove(toy);
        }

        // needs List of toys?
        // or, list of children that points to their list of toys?
        public List<Child> ChildrenWithToys { get; set; }

        public Bag()
        {
            ChildrenWithToys = new List<Child>();
        }
    }
}
