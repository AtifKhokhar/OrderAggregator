using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OrderAggregator
{
    public class MaxTotalCalculatorShould
    {
        private MaxTotalCalculator sut;
        private List<Order> testCollection;


        [SetUp]
        public void SetUp()
        {
            sut = new MaxTotalCalculator();
        }

        [Test]
        public void CalculateMaxTotalForCollectionType()
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
            var actualMaxTotal = sut.CalculateTotalFromCollection(testCollection);
            //assert
            Assert.That(actualMaxTotal.Equals(128.3));
        }

        [Test]
        public void CalculateMaxTotalForDictionary()
        {
            var testDictionary = testCollection.ToDictionary(k => k.OrderId, v => v);
            var actualMaxTotal = sut.CalculateTotalFromDictionary(testDictionary);
            //assert
            Assert.That(actualMaxTotal.Equals(128.3));
        }

    }
}
