using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace OrderAggregator
{
    public class Billable<T> where T : IOrder
    {
        private T type;
        public Billable(T type)
        {
            this.type = type;
        }

        public string PrintBill()
        {
            return $"Order Bill Details:\n OrderId: {type.OrderId}\n Name: {type.Name}\n Price: {type.Price}\n";
        }

    }
}