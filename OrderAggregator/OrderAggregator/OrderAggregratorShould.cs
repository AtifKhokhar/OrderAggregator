using System;
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
            
           
            
            OrderAggregator sut = new OrderAggregator();
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
            OrderAggregator sut = new OrderAggregator();
            var actualMaxPrice = sut.CalculateMaxPriceFromCollection(collectionType);
            //assert
            Assert.That(actualMaxPrice.Equals(355.2));
        }


        [Test]
        public void CalculateMostExpensiveGender()
        {
            OrderAggregator sut = new OrderAggregator();

            var actualMostExpensiveGender = sut.CalculateMostExpensiveGender();
            //assert
            Assert.That(actualMostExpensiveGender.Equals("F"));
        }

        [Test]
        public void CalculateMaxTotalFromOrderList()
        {
            OrderAggregator sut = new OrderAggregator();

            var actualMaxTotal = sut.CalculateTotalFromOrderList();
            //assert
            Assert.That(actualMaxTotal.Equals(1566.3));
        }
    }
}
