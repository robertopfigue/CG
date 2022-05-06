using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CG.Infra.Persistence
{
    public class CgDbContext : DbContext
    {
        public DbSet<DadosPessoa> DadosPessoais { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public CgDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public CgDbContext(DbContextOptions<CgDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
