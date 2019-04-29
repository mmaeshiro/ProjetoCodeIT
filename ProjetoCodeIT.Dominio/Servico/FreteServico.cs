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
    public class FreteServico : ServicoBase<Frete>, IFreteServico
    {
        private readonly IFreteRepositorio _freteRepositorio;

        public FreteServico(IFreteRepositorio freteRepositorio)
            :base(freteRepositorio)
        {
            _freteRepositorio = freteRepositorio;
        }
    }
}
