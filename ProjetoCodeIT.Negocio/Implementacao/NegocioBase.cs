using ProjetoCodeIT.Dominio.Interfaces.INegocio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Negocio.Implementacao
{
    public class NegocioBase<T> : IDisposable, INegocioBase<T> where T : class
    {
        //Ioc
        private readonly IServicoBase<T> _servicoBase;

        public NegocioBase(IServicoBase<T> servicoBase)
        {
            _servicoBase = servicoBase;
        }

        public bool Alterar(T entidade)
        {
            return _servicoBase.Alterar(entidade);
        }

        public void Dispose()
        {
            _servicoBase.Dispose();
        }

        public void Excluir(T entidade)
        {
            _servicoBase.Excluir(entidade);
        }

        public bool Inserir(T entidade)
        {
            return _servicoBase.Inserir(entidade);
        }

        public T ObterId(int? id)
        {
            return _servicoBase.ObterId(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _servicoBase.ObterTodos();
        }

        public Task<IEnumerable<T>> ObterTodosASync()
        {
            return _servicoBase.ObterTodosAsync();
        }
    }
}
