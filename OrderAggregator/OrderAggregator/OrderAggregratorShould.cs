﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace OrderAggregator
{
    [TestFixture]
    public class OrderAggregratorShould
    {
        private OrderAggregator sut;
        private Dictionary<string, IEnumerable<Order>> collectionTypes;

        [SetUp]
        public void Setup()
        {
            sut = new OrderAggregator();
            collectionTypes = new Dictionary<string, IEnumerable<Order>>()
            {
                { "List", sut.OrderList},
                { "Array", sut.OrderArray},
                { "Dictionary", sut.OrderDictionary.Values},
            };
        }


        [Test]
        public void ContainsAnOrderFromRaul()
        {
            var expectedOrderInList = new Order
            {
                OrderId = 1,
                Name = "Raul",
                Price = 26.7,
                Sex = "M"
            };
              
            //assert
            //can only assert on values between the list object and my test object because they are not the same instance objects
            Assert.That(sut.OrderList.Any(x => x.Name == expectedOrderInList.Name));
            Assert.That(sut.OrderList.Any(x => x.OrderId == expectedOrderInList.OrderId));


        }

        [TestCase("List")]
        [TestCase("Array")]
        [TestCase("Dictionary")]
        public void CalculateMaxPriceForCollectionType(string collectionType)
        {
            IEnumerable<Order> collection;
            collectionTypes.TryGetValue(collectionType,out collection);
            var actualMaxPrice = sut.CalculateMaxPriceFromCollection(collection);
            //assert
            Assert.That(actualMaxPrice.Equals(355.2));
        }


        [Test]
        public void CalculateMostExpensiveGender()
        {

            var actualMostExpensiveGender = sut.CalculateMostExpensiveGender();
            //assert
            Assert.That(actualMostExpensiveGender.Equals("F"));
        }

        [Test]
        public void CalculateMaxTotalFromOrderList()
        {

            var actualMaxTotal = sut.CalculateTotalFromOrderList();
            //assert
            Assert.That(actualMaxTotal.Equals(1566.3));
        }
    }
}
