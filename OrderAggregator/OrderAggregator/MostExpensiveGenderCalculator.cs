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
    }
}