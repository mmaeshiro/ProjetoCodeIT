using ProjetoCodeIT.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCodeIT.Infra.Mapeamento
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produto");

            HasKey(e => e.idProduto).Property(e => e.idProduto).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.nome).HasMaxLength(300).IsRequired();

        }

    }
}
