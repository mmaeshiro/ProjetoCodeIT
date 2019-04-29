using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Interfaces.INegocio
{
    public interface IItemViagemNegocio : INegocioBase<ItemViagem>
    {
        bool InserirItemViagem(ItemViagem itemViagem);

        ViagemResultadoObjetoValor GerarViagem();
    }
}
