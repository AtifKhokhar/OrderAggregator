using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAggregator
{
    public class MaxTotalCalculator
    {
        public double CalculateTotalFromCollection<T>(T collection) where T : IEnumerable<Order>
        {
            return collection.Sum(x => x.Price);
        }
        public double CalculateTotalFromDictionary(Dictionary<int, Order> orderDictionary)
        {
            double totalPrice = 0;
            foreach (Order order in orderDictionary.Values)
            {
                totalPrice += order.Price;
            }
            return totalPrice;
        }
    }
}
