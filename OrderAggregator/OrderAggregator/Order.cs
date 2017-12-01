namespace OrderAggregator
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Sex { get; set; }

       

        //public Order(int orderId,string name,float price,string sex)
        //{
        //    OrderId = orderId;
        //    Name = name;
        //    Price = price;
        //    Sex = sex;
        //}
    }
}