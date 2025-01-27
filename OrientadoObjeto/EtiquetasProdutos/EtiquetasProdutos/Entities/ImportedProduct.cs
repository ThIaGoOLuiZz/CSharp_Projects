using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetasProdutos.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Custom fee: $ ");
            sb.Append(CustomFee.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
