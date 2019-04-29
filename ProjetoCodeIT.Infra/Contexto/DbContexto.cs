using ProjetoCodeIT.Dominio.Entidade;
using ProjetoCodeIT.Infra.Mapeamento;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoCodeIT.Infra.Contexto
{
    public class DbContexto : DbContext
    {
        public DbContexto()
            :base("name=minhaConnectionStrings")
        {
        }

        public DbSet<Frete> Frete { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItemViagem> ItemViagem { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new FreteMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ItemViagemMap());
          
        }
    }
}
