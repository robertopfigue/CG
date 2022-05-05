using CG.Domain.Interfaces;

namespace CG.Domain.Entities
{
    public class Curso : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Instituicao { get; set; }
        public int Tipo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
