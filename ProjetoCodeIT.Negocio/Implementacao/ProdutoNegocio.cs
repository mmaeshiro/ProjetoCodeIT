using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;
using System.Collections.Generic;

namespace ProjetoCodeIT.Negocio.Implementacao
{
    public class ProdutoNegocio : NegocioBase<Produto>, IProdutoNegocio
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoNegocio(IProdutoServico produtoServico)
            : base(produtoServico)
        {
            _produtoServico = produtoServico;
        }

        //public IEnumerable<Produto> ObterProdutos()
        //{
        //    var produtos = _produtoServico.ObterTodos();
        //    return produtos;
        //}

        public bool AlterarProduto(int idProduto, string nome)
        {

            var produtoBD = _produtoServico.ObterId(idProduto);

            produtoBD.nome = nome;

            var retorno = _produtoServico.Alterar(produtoBD);

            return retorno;
        }

        public void ExcluirProduto(int idProduto)
        {
            var produtoBD = _produtoServico.ObterId(idProduto);

            _produtoServico.Excluir(produtoBD);
        }
    }

}
