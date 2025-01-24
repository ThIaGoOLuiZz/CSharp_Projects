using System.Globalization;
using OrdemPedidosComposicao.Entities;
using OrdemPedidosComposicao.Entities.Enums;

namespace OrdemPedidosComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(status, client);


            Console.Write("How many items to this order?: ");
            int value = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItrem orderItrem = new OrderItrem(quantity, product);

                order.AddItem(orderItrem);
            }
            Console.WriteLine("===========================");
            Console.WriteLine(order);
        }
    }
}
