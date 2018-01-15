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
                { "Dictionary", sut.OrderDictionary.Values}
            };
        }

        [Test]
        public void ContainsAnOrderFromGivenCustomerName()
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
        public void CalculateMaxPriceMostExpensiveGenderMaxTotalForGivenCollectionType(string collectionType)
        {
            collectionTypes.TryGetValue(collectionType, out var collection);
            var expectedResult = $"Max Price: 355.2\n" +
                                 $"Most Expensive Gender: F\n" +
                                 $"Total of all Orders: 1566.3\n";


            var actualResult = sut.CalculateAll(collection);
            //assert
            Assert.That(actualResult.Equals(expectedResult));
        }

        [Test]
        public void CalculateMaxPriceMostExpensiveGenderMaxTotalForDictionaryWithoutLambdaOrLinqMethods()
        {
            var expectedResult = $"Max Price: 355.2\n" +
                                 $"Most Expensive Gender: F\n" +
                                 $"Total of all Orders: 1566.3\n";


            var actualResult = sut.SimpleCalculateAllFromDictionary();
            //assert
            Assert.That(actualResult.Equals(expectedResult));
        }

    }
}
