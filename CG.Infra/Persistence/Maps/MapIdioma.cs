using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Map
{
    public class MapIdioma : MapBaseDomain<Idioma>
    {
        public MapIdioma() : base("Idioma") { }

        public override void Configure(EntityTypeBuilder<Idioma> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Nivel).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.IdPessoa).IsRequired();
        }
    }
}
