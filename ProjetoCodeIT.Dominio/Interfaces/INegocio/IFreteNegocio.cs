using ProjetoCodeIT.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Interfaces.INegocio
{
    public interface IFreteNegocio : INegocioBase<Frete>
    {
        bool AlterarFrete(int idFrete, decimal valor);

        void ExcluirFrete(int idFrete);
    }
}
