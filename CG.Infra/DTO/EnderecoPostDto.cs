namespace CG.Infra.DTO
{
    public class EnderecoPostDto
    {
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
    }
}
