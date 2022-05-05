using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Map
{
    public class MapHabilidade : MapBaseDomain<Habilidade>
    {
        public MapHabilidade() : base("Habilidade") { }

        public override void Configure(EntityTypeBuilder<Habilidade> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Descricao).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
