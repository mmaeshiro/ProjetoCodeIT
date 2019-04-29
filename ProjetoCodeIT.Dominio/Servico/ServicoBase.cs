using ProjetoCodeIT.Dominio.Interfaces.IRepositorio;
using ProjetoCodeIT.Dominio.Interfaces.IServico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Servico
{
    public class ServicoBase<T> : IDisposable, IServicoBase<T> where T : class
    {

        //IoC
        private readonly IRepositorioBase<T> _repositorio;

        public ServicoBase(IRepositorioBase<T> repositorio)
        {
            _repositorio = repositorio;
        }

        public bool Alterar(T entidade)
        {
            return _repositorio.Alterar(entidade);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public void Excluir(T entidade)
        {
            _repositorio.Excluir(entidade);
        }

        public bool Inserir(T entidade)
        {
            return _repositorio.Inserir(entidade);
        }

        public T ObterId(int? id)
        {
            return _repositorio.ObterId(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        public Task<IEnumerable<T>> ObterTodosAsync()
        {
            return _repositorio.ObterTodosASync();
        }
    }
}
