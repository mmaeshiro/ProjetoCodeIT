using ProjetoCodeIT.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Interfaces.INegocio
{ 
    public interface IProdutoNegocio : INegocioBase<Produto>
    {
        bool AlterarProduto(int idProduto, string nome);

        void ExcluirProduto(int idProduto);
    }
}
