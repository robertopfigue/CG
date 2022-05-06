using CG.Domain.Interfaces;

namespace CG.Domain.Entities
{
    public class DadosPessoa : BaseDomain, IExibivel
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Nacionalidade { get; set; }
        public string? Sexo { get; set; }
        public string? EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public virtual Endereco? Endereco { get; set; }

        public virtual Curriculo? Curriculo { get; set; }
    }
}
