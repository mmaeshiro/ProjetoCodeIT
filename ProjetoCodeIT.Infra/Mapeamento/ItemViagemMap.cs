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
    public class ItemViagemMap : EntityTypeConfiguration<ItemViagem>
    {
        public ItemViagemMap()
        {
            ToTable("ItemViagem");

            HasKey(x => x.idItemViagem).Property(x => x.idItemViagem).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.idProduto).IsRequired();

            Property(x => x.idFrete).IsRequired();

        }

    }
}
