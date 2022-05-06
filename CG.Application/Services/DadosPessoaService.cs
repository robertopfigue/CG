using CG.Domain.Entities;
using CG.Infra.DTO;
using CG.Infra.Exception;
using CG.Infra.Interfaces;
using CG.Infra.Persistence;

namespace CG.Application.Services
{
    public class DadosPessoaService
    {
        private readonly IRepositoryDadosPessoais _repositoryDadosPessoa;
        private readonly EnderecoService _serviceEndereco;

        public DadosPessoaService(IRepositoryDadosPessoais repositoryDadosPessoa, EnderecoService serviceEndereco)
        {
            _repositoryDadosPessoa = repositoryDadosPessoa;
            _serviceEndereco = serviceEndereco;
        }

        public async Task CriarDadosPessoa(DadosPessoaPostDto dto, CancellationToken ct)
        {
            DtoValidade(dto);

            var endereco = _serviceEndereco.CriaEndereco(dto.Endereco);

            var dadosPessoa = new DadosPessoa
            {
                Nome = dto.Nome,
                Email = dto.Email,
                DataNascimento = dto.DataNascimento,
                DataCriacao = DateTime.Now,
                Ativo = true,
                Endereco = endereco
            };

            await _repositoryDadosPessoa.Add(dadosPessoa, ct);

        }

        public void DtoValidade(DadosPessoaPostDto dto)
        {
            if (dto == null)
                throw new DomainException("Favor informar todos os dados.");

            if (string.IsNullOrEmpty(dto?.Email))
                throw new DomainException("Favor informar o Email.");

            if (string.IsNullOrEmpty(dto?.Nome))
                throw new DomainException("Favor informar o Nome.");

            if (dto?.DataNascimento == null)
                throw new DomainException("Favor informar a data de nascimento.");
        }
    }
}
