﻿namespace OrderAggregator
{
    public class Order : IOrder
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Sex { get; set; }

    }
}