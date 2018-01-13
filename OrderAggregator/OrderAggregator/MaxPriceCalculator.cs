using System.Collections.Generic;
using System.Linq;

namespace OrderAggregator
{
    public class MaxPriceCalculator
    {
        public double CalculateMaxPriceFromCollection<T>(T collection) where T : IEnumerable<Order>
        {
            return collection.Max(order => order.Price);
        }

        public double CalculateMaxPriceFromDictionary(Dictionary<int,Order> orderDictionary)
        {
            double maxPrice = 0;
            foreach (Order order in orderDictionary.Values)
            {
                if (order.Price >= maxPrice)
                {
                    maxPrice = order.Price;
                }

            }
            return maxPrice;
        }
    }
}