using CG.Domain.Entities;
using System.Collections.Generic;

namespace CG.Infra.Interfaces
{
    public interface IRepositoryCursos
    {
        public Task Add(Curso dadosPessoa);
        public Task Remove(Curso dadosPessoa);
        public Task<List<Curso>> GetAll();
        public Task<Curso> GetById(Guid id);
    }
}
