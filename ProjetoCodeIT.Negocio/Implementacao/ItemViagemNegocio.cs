using System.Collections.Generic;
using System.Linq;
using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;
using ProjetoCodeIT.Dominio.ObjetoValor;

namespace ProjetoCodeIT.Negocio.Implementacao
{
    public class ItemViagemNegocio : NegocioBase<ItemViagem>, IItemViagemNegocio
    {
        private readonly IItemViagemServico _itemViagemServico;
        private readonly IProdutoServico _produtoServico;
        private readonly IFreteServico _freteServico;

        public ItemViagemNegocio(IItemViagemServico itemViagemServico,
            IProdutoServico produtoServico,
            IFreteServico freteServico)
            : base(itemViagemServico)
        {
            _itemViagemServico = itemViagemServico;
            _produtoServico = produtoServico;
            _freteServico = freteServico;
        }

        public ViagemResultadoObjetoValor GerarViagem()
        {
            var listaItemViagem = _itemViagemServico.ObterTodos();

            var viagemResultadoObjetoValor = new ViagemResultadoObjetoValor();

            var viagemResultadoObjetoValor1 = new ViagemResultadoObjetoValor();

            if (listaItemViagem != null && listaItemViagem.Count() > 0)
            {

                var tempo = 0;
                foreach (var item in listaItemViagem.OrderByDescending(x => x.frete.valor))
                {
                    tempo += item.frete.tempo;

                    if (tempo > 21)
                    {
                        break;
                    }

                    //totalFrete += item.frete.valor;
                    viagemResultadoObjetoValor.valores += string.Format("{0},", item.frete.valor.ToString().Replace(",", "."));

                    viagemResultadoObjetoValor.produtos += string.Format("{0},", item.produto.nome);

                    viagemResultadoObjetoValor.totalFrete += item.frete.valor;

                    viagemResultadoObjetoValor.tempo += item.frete.tempo;

                }

                var tempo1 = 0;
                foreach (var item in listaItemViagem.OrderBy(x => x.frete.valor))
                {
                    tempo1 += item.frete.tempo;

                    if (tempo1 > 21)
                    {
                        break;
                    }

                    //totalFrete += item.frete.valor;
                    viagemResultadoObjetoValor1.valores += string.Format("{0},", item.frete.valor.ToString().Replace(",", "."));

                    viagemResultadoObjetoValor1.produtos += string.Format("{0},", item.produto.nome);

                    viagemResultadoObjetoValor1.totalFrete += item.frete.valor;

                    viagemResultadoObjetoValor1.tempo += item.frete.tempo;

                }
            }

            viagemResultadoObjetoValor.valores.Remove(viagemResultadoObjetoValor.valores.Length - 1);
            viagemResultadoObjetoValor.produtos.Remove(viagemResultadoObjetoValor.produtos.Length - 1);

            viagemResultadoObjetoValor1.valores.Remove(viagemResultadoObjetoValor1.valores.Length - 1);
            viagemResultadoObjetoValor1.produtos.Remove(viagemResultadoObjetoValor1.produtos.Length - 1);

            if (viagemResultadoObjetoValor.totalFrete > viagemResultadoObjetoValor1.totalFrete)
                return viagemResultadoObjetoValor;
            else
                return viagemResultadoObjetoValor1;
        }

        public bool InserirItemViagem(ItemViagem itemViagem)
        {
            var retorno = _itemViagemServico.Inserir(itemViagem);

            return retorno;
        }
    }
}
