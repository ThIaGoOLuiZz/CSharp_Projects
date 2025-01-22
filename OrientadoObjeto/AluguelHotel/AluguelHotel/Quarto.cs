using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelHotel
{
    internal class Quarto
    {
        public int Numero { get; set; }
        public Pessoa Pessoa { get; set; }
        public Aluguel Aluguel { get; set; }

        public Quarto(int numero, Pessoa pessoa, Aluguel aluguel)
        {
            Numero = numero;
            Pessoa = pessoa;
            Aluguel = aluguel;
        }
    }
}
