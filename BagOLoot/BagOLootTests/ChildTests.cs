using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BagOLoot;

namespace BagOLootTests
{
    [TestClass]
    public class ChildTests
    {
        [TestMethod]
        public void CanCreateInstanceOfChild()
        {
            Child joey = new Child("Joey");
            Assert.IsNotNull(joey);
        }

        [TestMethod]
        public void InstancesOfChildHaveListOfToys()
        {
            Child joey = new Child("Joey");
            Assert.IsInstanceOfType(joey.Toys, typeof(List<string>));
        }

        [TestMethod]
        public void ToysAreInitiallyNotDelivered()
        {
            Child joey = new Child("Joey");
            Assert.AreEqual(joey.ToysDelivered, false);
        }

        [TestMethod]
        public void ToysCanBeDelivered()
        {
            Child joey = new Child("Joey");
            joey.ToysDelivered = true;
            Assert.AreEqual(joey.ToysDelivered, true);
        }
    }
}
