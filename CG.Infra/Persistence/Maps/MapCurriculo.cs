using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Map
{
    public class MapCurriculo : MapBaseDomain<Curriculo>
    {
        public MapCurriculo() : base("Curriculo") { }

        public override void Configure(EntityTypeBuilder<Curriculo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(200);
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
