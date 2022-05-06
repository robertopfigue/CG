using CG.Domain.Interfaces;

namespace CG.Domain.Entities
{
    public class Curriculo : BaseDomain, IExibivel
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public bool Ativo { get; set ; }

        public virtual List<DadosPessoa>? DadosPessoais { get; set; }
        public virtual List<Curso>? Cursos { get; set; }
        public virtual List<Experiencia>? Experiencias { get; set; }
        public virtual List<Habilidade>? Habilidades { get; set; }
        public virtual List<Idioma>? Idiomas { get; set; }
    }
}
