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
            var orderDictionary = orderAggregator.OrderDictionary;

            Console.WriteLine("*****Order List Calculations*****");
            Console.Write(orderAggregator.CalculateAll(orderList));
            Console.WriteLine("*********************************");

            Console.WriteLine("*****Order Array Calculations*****");
            Console.Write(orderAggregator.CalculateAll(orderArray));
            Console.WriteLine("*********************************");

            Console.ReadLine();
        }
    }
}
