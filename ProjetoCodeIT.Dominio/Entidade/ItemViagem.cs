using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Entidade
{
    public class ItemViagem
    {

        public ItemViagem()
        {

        }

        public int idItemViagem { get; set; }

        public int idFrete { get; set; }

        public int idProduto { get; set; }

        public virtual Frete frete { get; set; }

        public virtual Produto produto { get; set; }

    }
}
