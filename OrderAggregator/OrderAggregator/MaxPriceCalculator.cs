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
    }
}