using CG.Domain.Entities;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryCurriculo
    {
        public Task Add(Curriculo dadosPessoa);
        public Task Remove(Curriculo dadosPessoa);
        public Task<List<Curriculo>> GetAll();
        public Task<Curriculo> GetById(Guid id);
    }
}
