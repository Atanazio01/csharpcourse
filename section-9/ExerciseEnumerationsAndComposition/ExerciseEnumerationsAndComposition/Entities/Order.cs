using ExerciseEnumerationsAndComposition.Entities.Enums;

namespace ExerciseEnumerationsAndComposition.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus status)
        {
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void removeItem(OrderItem item)
        {
           Item.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Item)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
