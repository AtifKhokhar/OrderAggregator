namespace OrderAggregator
{
    internal class BusinessOrder : IOrder
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string BusinessCompanyCode { get; set; }
    }
}