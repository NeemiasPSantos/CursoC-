using ExEnum.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

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
        public override string ToString()
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine("ORDER SUMMARY:");
            summary.AppendLine("Order Momment: " + DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"));
            summary.AppendLine("Order status: " + Status);
            summary.AppendLine("Client: " + Client + " " + Client.BirthDate + " - " + Client.Email);
            summary.AppendLine("Order Items");
            foreach (OrderItem item in Items) 
            {
                summary.AppendLine(item.ToString());
            }
            summary.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return summary.ToString();
        }
    }
}
