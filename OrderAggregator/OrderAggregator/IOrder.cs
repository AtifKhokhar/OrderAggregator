namespace OrderAggregator
{
    public interface IOrder
    {
         int OrderId { get; set; }
         string Name { get; set; }
         double Price { get; set; }

    }
}