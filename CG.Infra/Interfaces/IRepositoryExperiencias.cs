using CG.Domain.Entities;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryExperiencias
    {
        public Task Add(Experiencia dadosPessoa);
        public Task Remove(Experiencia dadosPessoa);
        public Task<List<Experiencia>> GetAll();
        public Task<Experiencia> GetById(Guid id);
    }
}
