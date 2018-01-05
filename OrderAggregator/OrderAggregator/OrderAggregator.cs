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

        public OrderAggregator()
        {
            OrderArray = OrderList.ToArray();
            OrderDictionary = OrderList.ToDictionary(order => order.OrderId, order => order);
        }

        public double CalculateMaxPriceForList()
        {
            return OrderList.Max(order => order.Price);
        }

        public double CalculateMaxPriceForArray()
        {
            return OrderArray.Max(order => order.Price);
        }

        public double CalculateMaxPriceForDictionary()
        {
            return OrderDictionary.Values.Max(order => order.Price);
        }

        public double CalculateMaxPriceFromCollection(string collectionType)
        {
            double maxPrice =0;
            if (collectionType == "List")
            {
              maxPrice = OrderList.Max(order => order.Price);
            }
            if (collectionType == "Array")
            {
              maxPrice = OrderArray.Max(order => order.Price);
            }
            if (collectionType == "Dictionary")
            {
              maxPrice = OrderDictionary.Values.Max(order => order.Price);
            }

            return maxPrice;
        }

        public double CalculateTotalFromOrderList()
        {
            return OrderList.Sum(x => x.Price);
        }

        public string CalculateMostExpensiveGender()
        {
            var maleTotal = 0.00;
            var femaleTotal = 0.00;
            foreach (var order in OrderList)
            {
                if(order.Sex.Equals("M"))
                {
                    maleTotal += order.Price;
                }
                if (order.Sex.Equals("F"))
                {
                    femaleTotal += order.Price;
                }
            }

            return maleTotal > femaleTotal ? "M" : "F";
        }

    }
}
