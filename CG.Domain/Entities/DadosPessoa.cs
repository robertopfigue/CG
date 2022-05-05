using CG.Domain.Interfaces;

namespace CG.Domain.Entities
{
    public class DadosPessoa : BaseDomain, IExibivel
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Curso>? Cursos { get; set; }
        public virtual List<Experiencia>? Experiencias { get; set; }
        public virtual List<Habilidade>? Habilidades { get; set; }
        public virtual List<Idioma>? Idiomas { get; set; }
    }
}
