using System.Collections.Generic;
using System.Linq;

namespace OrderAggregator
{
    public class MostExpensiveGenderCalculator
    {
        public string CalculateMostExpensiveGenderFromCollection<T>(T collection) where T : IEnumerable<Order>
        {

            var maleTotal = collection.Where(order => order.Sex.Equals("M")).Sum(order => order.Price);
            var femaleTotal = collection.Where(order => order.Sex.Equals("F")).Sum(order => order.Price);

            return maleTotal > femaleTotal ? "M" : "F";
        }

        public string CalculateMostExpensiveGenderFromDictionary(Dictionary<int, Order> orderDictionary)
        {
            var maleTotal = 0.00;
            var femaleTotal = 0.00;
            foreach (var order in orderDictionary.Values)
            {
                if (order.Sex.Equals("M"))
                    maleTotal += order.Price;
                if (order.Sex.Equals("F"))
                    femaleTotal += order.Price;
            }

            return maleTotal > femaleTotal ? "M" : "F";
        }
    }
}