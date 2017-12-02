﻿using System;
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

        public  Order[] OrderArray = new Order[]
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


        public double CalculateMaxPriceForList()
        {
            double previousPrice = 0;
            double maxPrice = 0;
            foreach (var order in OrderList)
            {
                if (order.Price >= previousPrice)
                {
                    maxPrice = order.Price;
                    previousPrice = order.Price;
                }
            }
            return maxPrice;
        }

        public double CalculateMaxPriceForArray()
        {
            double previousPrice = 0;
            double maxPrice = 0;
            for (int i = 0; i < OrderArray.Length; i++)
            {
                if(OrderArray[i].Price >= previousPrice)
                {
                    maxPrice = OrderArray[i].Price;
                    previousPrice = OrderArray[i].Price;
                }
            }
            return maxPrice;
        }
    }
}
