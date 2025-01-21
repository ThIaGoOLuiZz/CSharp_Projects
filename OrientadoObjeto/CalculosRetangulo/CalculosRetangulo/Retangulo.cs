using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosRetangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculoArea()
        {
            return Largura * Altura;
        }

        public double CalculoPerimetro()
        {
            return (2 * Altura) + (2 * Largura);
        }

        public double CalculoDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return $"AREA: {CalculoArea().ToString("F2")} \nPERÍMETRO: {CalculoPerimetro().ToString("F2")} \nDIAGONAL: {CalculoDiagonal().ToString("F2")}";
        }
    }
}
