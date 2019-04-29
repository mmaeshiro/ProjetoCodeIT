using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Dominio.Interfaces.IRepositorio
{
    public interface IRepositorioBase<T> where T : class 
    {
        T ObterId(int? id);

        IEnumerable<T> ObterTodos();

        Task<IEnumerable<T>> ObterTodosASync();

        bool Inserir(T entidade);

        bool Alterar(T entidade);

        void Excluir(T entidade);

        void Dispose();

    }
}
