using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BagOLoot;
using System.Linq;

namespace BagOLootTests
{
    [TestClass]
    public class BagTests
    {
        [TestMethod]
        public void CanCreateInstanceOfBag()
        {
            Bag bag = new Bag();
            Assert.IsNotNull(bag);
        }

        [TestMethod]
        public void BagContainsListOfChildren()
        {
            Bag bag = new Bag();
            Assert.IsInstanceOfType(bag.ChildrenWithToys, typeof(List<Child>));
        }

        [TestMethod]
        public void CanAddToysToBag()
        {
            Bag bag = new Bag();
            Child bobby = new Child("Bobby");
            bag.Add(bobby, "model airplane");
            Assert.IsTrue(bobby.Toys.First() == "model airplane");
        }

        [TestMethod]
        public void CanRemoveToysFromBag()
        {
            Bag bag = new Bag();
            Child bobby = new Child("Bobby");
            bobby.Toys = new List<string>{"model airplane", "action figure"};
            bag.Remove(bobby, "action figure");
            Assert.IsFalse(bobby.Toys.Contains("action figure"));
        }

        [TestMethod]
        public void RemovingToysFromBagDoesNotAffectToysStillInBag()
        {
            Bag bag = new Bag();
            Child bobby = new Child("Bobby");
            bobby.Toys = new List<string> { "model airplane", "action figure" };
            bag.Remove(bobby, "action figure");
            Assert.IsTrue(bobby.Toys.Contains("model airplane"));
        }
    }
}
