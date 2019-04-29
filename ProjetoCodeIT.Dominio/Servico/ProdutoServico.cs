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
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
            :base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
    }
}
