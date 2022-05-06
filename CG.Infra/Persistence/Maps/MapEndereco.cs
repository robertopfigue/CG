using CG.Domain.Entities;
using CG.Infra.Persistence.Map;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CG.Infra.Persistence.Maps
{
    public class MapEndereco : MapBaseDomain<Endereco>
    {
        public MapEndereco() : base("Endereco") { }

        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Cidade).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Logradouro).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Cep).HasMaxLength(8).IsRequired();
        }
    }
}
