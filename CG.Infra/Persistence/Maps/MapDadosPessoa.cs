using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Map
{
    public class MapDadosPessoa : MapBaseDomain<DadosPessoa>
    {
        public MapDadosPessoa() : base("DadosPessoa") { }

        public override void Configure(EntityTypeBuilder<DadosPessoa> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
