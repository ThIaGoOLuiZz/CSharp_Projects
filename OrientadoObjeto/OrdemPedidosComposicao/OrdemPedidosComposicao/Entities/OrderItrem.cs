using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedidosComposicao.Entities
{
    internal class OrderItrem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }
        public Product Product = new Product();

        public OrderItrem()
        {

        }
        public OrderItrem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
