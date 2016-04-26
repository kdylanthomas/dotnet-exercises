using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOLoot
{
    class Program
    {
        // arg1 is a method, e.g. Add, Remove
        // arg2 is a child
        // arg3 is a toy that belongs to a child

        static void Main(string[] args)
        {
            Bag lootBag = new Bag();
            Child suzy = new Child("Suzy");
            suzy.Toys.Add("puzzle");
            suzy.Toys.Add("racecar");
            Child joey = new Child("Joey");
            joey.Toys.Add("baseball");
            lootBag.ChildrenWithToys.Add(suzy);
            lootBag.ChildrenWithToys.Add(joey);

            switch (args[0].ToUpper())
            {
                case "ADD":
                    bool childFound = false;
                    foreach (Child child in lootBag.ChildrenWithToys)
                    {
                        if (child.Name.ToLower() == args[1].ToLower())
                        {
                            lootBag.Add(child, args[2]);
                            Console.WriteLine("added {0} to {1}'s list", args[2], child.Name);
                            Console.WriteLine(child.Toys.Count);
                            childFound = true;
                        }

                    }
                    if (childFound == false)
                    {
                        Console.WriteLine("This child is not on the list");
                    }
                    break;
                case "REMOVE":
                    childFound = false;
                    foreach (Child child in lootBag.ChildrenWithToys)
                    {
                        if (child.Name.ToLower() == args[1].ToLower())
                        {
                            lootBag.Remove(child, args[2]);
                            Console.WriteLine("removed {0} from {1}'s list", args[2], child.Name);
                            childFound = true;
                        }
                    }
                    if (childFound == false)
                    {
                        Console.WriteLine("This child is not on the list");
                    }
                    break;
                case "LS":
                    childFound = false;
                    if (args.Length == 3 && args[1] == "delivered" && args[2] != null)
                    {
                        foreach (Child child in lootBag.ChildrenWithToys)
                        {
                            if (child.Name.ToLower() == args[2].ToLower())
                            {
                                child.ToysDelivered = true;
                                Console.WriteLine("Delivered {0}'s toys!", child.Name);
                                childFound = true;
                            }
                        }
                        if (childFound == false)
                        {
                            Console.WriteLine("who dat?");
                        }
                    }
                    else if (args.Length == 2 && args[1] != "delivered")
                    {
                        foreach (Child child in lootBag.ChildrenWithToys)
                        {
                            if (child.Name.ToLower() == args[1].ToLower())
                            {
                                foreach (string toy in child.Toys)
                                {
                                    Console.WriteLine(toy);
                                }
                                childFound = true;
                            }
                        }
                        if (childFound == false)
                        {
                            Console.WriteLine("who dat?");
                        }
                    }
                    else if (args.Length == 1)
                    {
                        foreach (Child child in lootBag.ChildrenWithToys)
                        {
                            Console.WriteLine(child.Name);
                        }
                    }
                    break;
                default:
                    break;
            }
            

        }
    }
}
