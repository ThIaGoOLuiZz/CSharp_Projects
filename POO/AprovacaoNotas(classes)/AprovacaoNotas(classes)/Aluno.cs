using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AprovacaoNotas_classes_
{
    internal class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            if(NotaFinal() < 60)
            {
                return $"NOTA FINAL: {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                       $"REPROVADO!\n" +
                       $"FALTARAM {(60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} pontos!";
            }

            return $"NOTA FINAL: {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"APROVADO!";
        }
    }
}
