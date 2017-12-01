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

        [Test]
        public void CalculateMaxPrice()
        {
            OrderAggregator sut = new OrderAggregator();

            var actualMaxPrice = sut.CalculateMaxPrice();
            //assert
            Assert.That(actualMaxPrice.Equals(355.2));
        }
    }
}
