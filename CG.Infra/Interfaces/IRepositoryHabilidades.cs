using CG.Domain.Entities;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryHabilidades
    {
        public Task Add(Habilidade dadosPessoa);
        public Task Remove(Habilidade dadosPessoa);
        public Task<List<Habilidade>> GetAll();
        public Task<Habilidade> GetById(Guid id);
    }
}
