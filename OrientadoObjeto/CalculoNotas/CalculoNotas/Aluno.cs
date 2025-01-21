using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNotas
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalculoNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string ValidaNota(double notaFinal)
        {
            if (notaFinal < 60.00)
            {
                return $"REPROVADO! Faltaram {(60.00 - notaFinal).ToString("F2")}";
            }
            return "APROVADO";
        }
    }
}
