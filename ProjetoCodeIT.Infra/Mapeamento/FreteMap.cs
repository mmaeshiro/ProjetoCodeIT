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
    public class FreteMap : EntityTypeConfiguration<Frete>
    {

        public FreteMap()
        {
            ToTable("Frete");

            HasKey(x => x.idFrete).Property(x => x.idFrete).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.valor).IsRequired();

            Property(x => x.tempo).IsRequired();

        }

    }
}
