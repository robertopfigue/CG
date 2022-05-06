using CG.Domain.Entities;
using CG.Infra.DTO;
using CG.Infra.Exception;
using CG.Infra.Interfaces;

namespace CG.Application.Services
{
    public class EnderecoService
    {
        private readonly IRepositoryEndereco _repositoryEndereco;

        public EnderecoService(IRepositoryEndereco repositoryEndereco)
        {
            _repositoryEndereco = repositoryEndereco;
        }

        public Endereco CriaEndereco(EnderecoPostDto dto)
        {
            DtoValidade(dto);

            var endereco = new Endereco
            {
                Cidade = dto.Cidade,
                Bairro = dto.Bairro,
                Logradouro = dto.Logradouro,
                Numero = dto.Numero,
                Complemento = dto.Complemento,
                Cep = dto.Cep,
            };

            return endereco;
        }

        public void DtoValidade(EnderecoPostDto dto)
        {
            if (dto == null)
                throw new DomainException("Favor informar todos os dados.");

            if (string.IsNullOrEmpty(dto?.Cidade))
                throw new DomainException("Favor informar a Cidade.");

            if (string.IsNullOrEmpty(dto?.Bairro))
                throw new DomainException("Favor informar o Bairro.");

            if (string.IsNullOrEmpty(dto?.Logradouro))
                throw new DomainException("Favor informar o Logradouro.");

            if (string.IsNullOrEmpty(dto?.Cep))
                throw new DomainException("Favor informar o CEP.");
        }
    }
}
