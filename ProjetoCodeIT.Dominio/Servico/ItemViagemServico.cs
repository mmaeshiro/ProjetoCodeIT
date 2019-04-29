using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.Interfaces.IRepositorio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Servico
{
    public class ItemViagemServico : ServicoBase<ItemViagem> , IItemViagemServico
    {
        private readonly IItemViagemRepositorio _itemViagemRepositorio;

        public ItemViagemServico(IItemViagemRepositorio itemViagemRepositorio)
            :base(itemViagemRepositorio)
        {
            _itemViagemRepositorio = itemViagemRepositorio;
        }
    }
}
