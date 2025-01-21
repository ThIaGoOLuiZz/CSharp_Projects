using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolar
{
    internal class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static double CalculaConversao(double cotacao, double valor)
        { 
            double valorTotal = (valor * cotacao);
            double imposto = (Iof / 100) * valorTotal;
            return valorTotal + imposto;
        }
    }
}
