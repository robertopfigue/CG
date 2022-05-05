using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Map
{
    public class MapCurso : MapBaseDomain<Curso>
    {
        public MapCurso() : base("Curso") { }

        public override void Configure(EntityTypeBuilder<Curso> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Instituicao).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Tipo).IsRequired();
            builder.Property(x => x.DataInicio).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
