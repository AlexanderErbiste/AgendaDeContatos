using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos.Model
{
    internal class Contato
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

    }
}
