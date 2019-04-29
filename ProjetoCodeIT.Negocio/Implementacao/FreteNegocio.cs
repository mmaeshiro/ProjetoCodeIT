using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;

namespace ProjetoCodeIT.Negocio.Implementacao
{
    public class FreteNegocio : NegocioBase<Frete>, IFreteNegocio
    {
        private readonly IFreteServico _freteServico;

        public FreteNegocio(IFreteServico freteServico) 
            : base(freteServico)
        {
            _freteServico = freteServico;
        }

        public bool AlterarFrete(int idFrete, decimal valor)
        {
            var freteBD = _freteServico.ObterId(idFrete);

            freteBD.valor = valor;

            var retorno = _freteServico.Alterar(freteBD);

            return retorno;
        }

        public void ExcluirFrete(int idFrete)
        {
            var freteBD = _freteServico.ObterId(idFrete);

            _freteServico.Excluir(freteBD);
        }

    }
}
