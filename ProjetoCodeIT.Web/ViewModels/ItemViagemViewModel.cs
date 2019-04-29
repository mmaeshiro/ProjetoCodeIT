using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCodeIT.Web.ViewModels
{
    public class ItemViagemViewModel
    {
        public int idItemViagem { get; set; }

        public int idFrete { get; set; }

        public int idProduto { get; set; }

        public virtual FreteViewModel freteViewModel { get; set; }

        public virtual ProdutoViewModel produtoViewModel { get; set; }

        public virtual IEnumerable<FreteViewModel> listaFreteViewModel { get; set; }

        public virtual IEnumerable<ProdutoViewModel> listaProdutoViewModel { get; set; }
    }
}