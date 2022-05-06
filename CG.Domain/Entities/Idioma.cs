using CG.Domain.Interfaces;

namespace CG.Domain.Entities
{
    public class Idioma : BaseDomain, IExibivel
    {
        public string? Nome { get; set; }
        public string? Nivel { get; set; }
        public bool Ativo { get; set; }

        public virtual Curriculo? Curriculo { get; set; }
    }
}
