﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OrderAggregator
{
    public class MostExpensiveGenderCalculatorShould
    {
        private MostExpensiveGenderCalculator sut;
        private List<Order> testCollection;

        [SetUp]
        public void SetUp()
        {
            sut = new MostExpensiveGenderCalculator();
        }

        [Test]
        public void CalculateMostExpensiveGenderForCollectionType()
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
                    Name = "Jane",
                    Price = 25.4,
                    Sex = "F"
                },
                new Order
                {
                    OrderId = 3,
                    Name = "Maria",
                    Price = 76.2,
                    Sex = "F"
                }
            };
            var actualMostExpensiveGender = sut.CalculateMostExpensiveGenderFromCollection(testCollection);
            //assert
            Assert.That(actualMostExpensiveGender.Equals("F"));
        }

        [Test]
        public void CalculateMostExpensiveGenderForDictionary()
        {
            var testDictionary = testCollection.ToDictionary(k => k.OrderId, v => v);
            var actualMostExpensiveGender = sut.CalculateMostExpensiveGenderFromDictionary(testDictionary);
            //assert
            Assert.That(actualMostExpensiveGender.Equals("F"));
        }

    }
}
