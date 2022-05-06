namespace CG.Domain.Entities
{
    public class Endereco : BaseDomain
    {
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }

        public virtual List<DadosPessoa>? DadosPessoais { get; set; }
    }
}
