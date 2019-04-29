using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Entidade
{
    public class Frete
    {
        public Frete()
        {

        }

        public int idFrete { get; set; }

        public decimal valor { get; set; }

        public int tempo { get; set; }
    }
}
