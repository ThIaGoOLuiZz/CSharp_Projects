using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdemPedidosComposicao.Entities.Enums;
using OrdemPedidosComposicao.Entities;

namespace OrdemPedidosComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        List<OrderItrem> OrderItems = new List<OrderItrem>();

        public Order()
        {

        }
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItrem orderItrem)
        {
            OrderItems.Add(orderItrem);
        }
        public void RemoveItem(OrderItrem orderItrem)
        {
            OrderItems.Remove(orderItrem);
        }

        public double Total()
        {
            double total = 0.0;
            foreach(OrderItrem orderItrem in OrderItems)
            {
                total += orderItrem.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append("(");
            sb.Append(Client.Date.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items: ");
            foreach(OrderItrem orderItem in OrderItems)
            {
                sb.Append(orderItem.Product.Name);
                sb.Append(", $");
                sb.Append(orderItem.Price);
                sb.Append(", Quantity: "); 
                sb.Append(orderItem.Quantity);
                sb.Append(", Subtotal: $");
                sb.Append(orderItem.SubTotal());
            }
            sb.AppendLine();
            sb.Append("Total price: $");
            sb.Append(Total());

            return sb.ToString();
        }
    }
}
