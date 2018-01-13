using NUnit.Framework;

namespace OrderAggregator
{
    public class BillableShould
    {
        [Test]
        public void PrintOrderBill()
        {
            IOrder testOrder = new Order()
            {
                OrderId = 15,
                Name = "TestOrder",
                Price = 10.5,
                Sex = "F"
            };

            var expectedResult = "Order Bill Details:\n OrderId: 15\n Name: TestOrder\n Price: 10.5\n";
            var sut  = new Billable<IOrder>(testOrder);
            var actualResult = sut.PrintBill();

            Assert.That(actualResult.Equals(expectedResult));
        }

        [Test]
        public void PrintBusinessOrderBill()
        {
            IOrder testOrder = new BusinessOrder()
            {
                OrderId = 20,
                Name = "TestBusinessOrder",
                Price = 150.5,
                BusinessCompanyCode = "TB128"
            };

            var expectedResult = "Order Bill Details:\n OrderId: 20\n Name: TestBusinessOrder\n Price: 150.5\n";
            var sut = new Billable<IOrder>(testOrder);
            var actualResult = sut.PrintBill();

            Assert.That(actualResult.Equals(expectedResult));
        }

    }
}