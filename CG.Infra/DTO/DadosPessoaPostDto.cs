namespace CG.Infra.DTO
{
    public class DadosPessoaPostDto
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoPostDto? Endereco { get; set; }
    }
}
