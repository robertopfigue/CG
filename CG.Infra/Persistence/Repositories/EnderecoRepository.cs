using CG.Domain.Entities;
using CG.Infra.Exception;
using CG.Infra.Interfaces;

namespace CG.Infra.Persistence.Repositories
{
    public class EnderecoRepository : BaseRepository, IRepositoryEndereco
    {
        public EnderecoRepository(CgDbContext _context) : base(_context)
        {
        }

        public async Task<Guid> Add(Endereco endereco)
        {
            try
            {
                await _context.Enderecos.AddAsync(endereco);
                await _context.SaveChangesAsync();
                return endereco.Id;
            }
            catch
            {
                throw new DomainException("Ocorreu um erro, entre em contato com o administrador do sistema.");
            }
        }

        public Task<List<Endereco>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
