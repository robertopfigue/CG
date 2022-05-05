using CG.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CG.Infra.Persistence
{
    public class CurriculoContext : DbContext
    {
        public DbSet<DadosPessoa> DadosPessoais { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public CurriculoContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public CurriculoContext(DbContextOptions<CurriculoContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
