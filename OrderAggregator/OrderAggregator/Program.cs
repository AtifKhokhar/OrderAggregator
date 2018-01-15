using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderAggregator = new OrderAggregator();
            var orderList = orderAggregator.OrderList;
            var orderArray = orderAggregator.OrderArray;

            Action<string> printAction = (x) => Console.WriteLine($"*****Order {x} Calculations*****");

            var orderBillable = new Billable<IOrder>(orderList.Find(order => order.OrderId == 1));
            var businessOrder = new BusinessOrder()
            {
                OrderId = 100,
                BusinessCompanyCode = "LSLI100SL",
                Name = "LaserLine Print Ltd",
                Price = 800.5
            };
            var businessOrderBillable = new Billable<IOrder>(businessOrder);

            printAction.Invoke("List");
            Console.Write(orderAggregator.CalculateAll(orderList));
            Console.WriteLine("*********************************\n");

            printAction.Invoke("Array");
            Console.Write(orderAggregator.CalculateAll(orderArray));
            Console.WriteLine("*********************************\n");

            Console.WriteLine("*****Simple Order Dictionary Calculations*****");
            Console.Write(orderAggregator.SimpleCalculateAllFromDictionary());
            Console.WriteLine("*********************************\n");

            Console.WriteLine("*****Bill Details for Order*****");
            Console.Write(orderBillable.PrintBill());
            Console.WriteLine("*********************************\n");

            Console.WriteLine("*****Bill Details for Business Order*****");
            Console.Write(businessOrderBillable.PrintBill());
            Console.WriteLine("*********************************\n");

            Console.ReadLine();
        }
    }
}
