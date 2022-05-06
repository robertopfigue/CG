using CG.Domain.Entities;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryDadosPessoais
    {
        public Task Add(DadosPessoa dadosPessoa, CancellationToken ct);
        public void Remove(DadosPessoa dadosPessoa);
        public Task<List<DadosPessoa>> GetAll();
        public Task<DadosPessoa?> GetById(Guid id);
    }
}
