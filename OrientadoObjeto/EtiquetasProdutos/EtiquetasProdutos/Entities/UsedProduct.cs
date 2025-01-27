using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetasProdutos.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
            
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder  sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (Used) $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.Append(")");

            return sb.ToString();
        }
    }
}
