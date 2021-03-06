﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OrderAggregator
{
    public class MaxPriceCalculatorShould
    {
        private MaxPriceCalculator sut;
        private List<Order> testCollection;

        [SetUp]
        public void SetUp()
        {
            sut = new MaxPriceCalculator();
        }

        [Test]
        public void CalculateMaxPriceForCollectionType()
        {
             testCollection = new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    Name = "Raul",
                    Price = 26.7,
                    Sex = "M"
                },

                new Order
                {
                    OrderId = 2,
                    Name = "Stephan",
                    Price = 25.4,
                    Sex = "M"
                },
                new Order
                {
                    OrderId = 3,
                    Name = "Maria",
                    Price = 76.2,
                    Sex = "F"
                }
            };
            var actualMaxPrice = sut.CalculateMaxPriceFromCollection(testCollection);
            //assert
            Assert.That(actualMaxPrice.Equals(76.2));
        }

        [Test]
        public void CalculateMaxPriceForDictionary()
        {
            var testDictionary = testCollection.ToDictionary(k => k.OrderId, v => v);
            var actualMaxPrice = sut.CalculateMaxPriceFromDictionary(testDictionary);
            //assert
            Assert.That(actualMaxPrice.Equals(76.2));
        }


    }
}
