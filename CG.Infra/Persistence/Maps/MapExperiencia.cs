using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Map
{
    public class MapExperiencia : MapBaseDomain<Experiencia>
    {
        public MapExperiencia() : base("Experiencia") { }

        public override void Configure(EntityTypeBuilder<Experiencia> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Atividades).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Cargo).HasMaxLength(120).IsRequired();
            builder.Property(x => x.Empresa).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Atual).HasDefaultValue(false).IsRequired();
            builder.Property(x => x.DataInicio).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.IdPessoa).IsRequired();
        }
    }
}
