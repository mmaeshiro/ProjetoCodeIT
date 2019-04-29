using ProjetoCodeIT.Dominio.Interfaces.IRepositorio;
using ProjetoCodeIT.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Infra.Implementacao
{
    public class RepositorioBase<T> : IDisposable, IRepositorioBase<T> where T : class
    {
        protected DbSet<T> _table;
        protected DbContexto Db = new DbContexto();
        bool disposed = false;

        public bool Alterar(T entidade)
        {
            Db.Entry(entidade).State = EntityState.Modified;
            return Salvar();
        }     

        public void Excluir(T entidade)
        {
            Db.Set<T>().Attach(entidade);
            Db.Set<T>().Remove(entidade);
            Db.SaveChanges();
        }

        public bool Inserir(T entidade)
        {
            Db.Set<T>().Add(entidade);
            return Salvar();
        }

        public T ObterId(int? id)
        {
            var entidade = default(T);
            if (id != null)
            {
                entidade = Db.Set<T>().Find(id);
            }
            return entidade;
        }

        public IEnumerable<T> ObterTodos()
        {
            IEnumerable<T> lstEntidade = Db.Set<T>().ToList();
            return lstEntidade;
        }

        public async Task<IEnumerable<T>> ObterTodosASync()
        {
            IEnumerable<T> lstEntidade = await Db.Set<T>().ToListAsync();
            return lstEntidade;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
                Db.Dispose();
            disposed = true;
        }

        private bool Salvar()
        {
            Db.SaveChanges();
            return true;
        }
    }
}
