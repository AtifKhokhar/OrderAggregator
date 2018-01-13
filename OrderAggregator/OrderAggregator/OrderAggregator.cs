using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace OrderAggregator
{
    public class OrderAggregator
    {
        public List<Order> OrderList  = new List<Order>
        {
           new Order  {
            OrderId = 1,
            Name = "Raul",
            Price = 26.7,
            Sex = "M"
            },

            new Order {
            OrderId = 2,
            Name = "Stephan",
            Price = 25.4,
            Sex = "M"
            },
             new Order{
            OrderId = 3,
            Name = "Maria",
            Price = 76.2,
            Sex = "F"
        },
        new Order {
            OrderId = 4,
            Name = "Clara",
            Price = 15.4,
            Sex = "F"
        },
        new Order{
            OrderId = 5,
            Name= "Drogon",
            Price = 99.3,
            Sex= "M"
        },
        new Order {
            OrderId = 6,
            Name= "Mikasa",
            Price = 55.2,
            Sex= "F"
        },
        new Order{
            OrderId = 7,
            Name = "Raul",
            Price = 26.7,
            Sex= "M"
        },
        new Order {
            OrderId= 8,
            Name = "Stephan",
            Price = 25.4,
            Sex= "M"
        },
        new Order{
            OrderId= 9,
            Name= "Maria",
            Price= 76.2,
            Sex= "F"
        },
        new Order {
            OrderId= 10,
            Name = "Clara",
            Price = 215.4,
            Sex = "F"
        },
        new Order{
            OrderId= 11,
            Name = "Drogon",
            Price = 99.3,
            Sex = "M"
        },
        new Order {
            OrderId= 12,
            Name= "Mikasa",
            Price= 55.2,
            Sex= "F"
        },
        new Order {
            OrderId= 13,
            Name= "Samira",
            Price= 115.4,
            Sex= "F"
        },
        new Order{
            OrderId= 14,
            Name= "Siryu",
            Price= 299.3,
            Sex= "M"
        },
        new Order {
            OrderId= 15,
            Name= "Lara",
            Price= 355.2,
            Sex= "F"
        }

        };

        public Order[] OrderArray;

        public Dictionary<int, Order> OrderDictionary; 

        private MaxPriceCalculator maxPriceCalculator;
        private MostExpensiveGenderCalculator mostExpensiveGenderCalculator;
        private MaxTotalCalculator maxTotalCalculator;
        public OrderAggregator()
        {
            OrderArray = OrderList.ToArray();
            OrderDictionary = OrderList.ToDictionary(order => order.OrderId, order => order);
            maxPriceCalculator = new MaxPriceCalculator();
            mostExpensiveGenderCalculator = new MostExpensiveGenderCalculator();
            maxTotalCalculator = new MaxTotalCalculator();
            
        }

        public string CalculateAll<T>(T collection) where T : IEnumerable<Order>
        {
            var maxPrice = maxPriceCalculator.CalculateMaxPriceFromCollection(collection);
            var mostExpensiveGender = mostExpensiveGenderCalculator.CalculateMostExpensiveGenderFromCollection(collection);
            var orderTotal = maxTotalCalculator.CalculateTotalFromCollection(collection);
            return $"Max Price: {maxPrice}\n" +
                   $"Most Expensive Gender: {mostExpensiveGender}\n" +
                   $"Total of all Orders: {orderTotal}\n";
        }

        public string SimpleCalculateAllFromDictionary()
        {
            var maxPrice = maxPriceCalculator.CalculateMaxPriceFromDictionary(this.OrderDictionary);
            var mostExpensiveGender = mostExpensiveGenderCalculator.CalculateMostExpensiveGenderFromDictionary(this.OrderDictionary);
            var orderTotal = maxTotalCalculator.CalculateTotalFromDictionary(this.OrderDictionary);
            return $"Max Price: {maxPrice}\n" +
                   $"Most Expensive Gender: {mostExpensiveGender}\n" +
                   $"Total of all Orders: {orderTotal}\n";
        }
    }
}
