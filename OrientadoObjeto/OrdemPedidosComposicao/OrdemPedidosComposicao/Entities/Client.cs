using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedidosComposicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client()
        {
            
        }
        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }
    }
}
