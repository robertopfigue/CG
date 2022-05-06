using CG.Domain.Entities;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryIdiomas
    {
        public Task Add(Idioma dadosPessoa);
        public Task Remove(Idioma dadosPessoa);
        public Task<List<Idioma>> GetAll();
        public Task<Idioma> GetById(Guid id);
    }
}
