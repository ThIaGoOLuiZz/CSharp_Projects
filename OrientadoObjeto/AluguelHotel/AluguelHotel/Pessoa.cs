using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelHotel
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
