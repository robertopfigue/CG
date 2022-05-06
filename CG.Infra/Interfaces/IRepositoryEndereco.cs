using CG.Domain.Entities;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryEndereco
    {
        public Task<Guid> Add(Endereco endereco);
        public Task Remove(Endereco endereco);
        public Task<List<Endereco>> GetAll();
        public Task<Endereco> GetById(Guid id);
    }
}
