using ExEnum.Entities;
using ExEnum.Entities.Enums;
using System.Globalization;

namespace ExEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Bith date (DD/MM/YYYY): ");
            DateTime bithDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, bithDate);
            Console.WriteLine("Enter Order Status: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #{0} Item data:", i);
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.Items.Add(item);                                
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}