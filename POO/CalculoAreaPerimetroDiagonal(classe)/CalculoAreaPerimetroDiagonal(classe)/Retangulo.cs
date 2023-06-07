using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculoAreaPerimetroDiagonal_classe_
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        // Metodo para calcular area
        public double Area()
        {
            return (Largura * Altura);
        }

        // Metodo para calcular perimetro
        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        // Metodo para calcular a diagonal
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) +
                   "\nPERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + 
                   "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
