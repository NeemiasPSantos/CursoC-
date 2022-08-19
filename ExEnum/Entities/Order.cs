using ExEnum.Entities.Enums;

namespace ExEnum.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() 
        {
        }       
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem) 
        {
            Items.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderitem) 
        {
            Items.Remove(orderitem);
        }

        public double Total() 
        {
            double sum = 0;
            foreach (OrderItem obj in Items) 
            {
                sum =+ obj.SubTotal();
            }
            return sum;
        }
    }
}
