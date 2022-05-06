using CG.Domain.Entities;
using CG.Infra.Exception;
using CG.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CG.Infra.Persistence.Repositories
{
    public class DadosPessoaRepository : BaseRepository, IRepositoryDadosPessoais
    {
        public DadosPessoaRepository(CgDbContext _context) : base(_context)
        {
        }

        public async Task Add(DadosPessoa dadosPessoa, CancellationToken ct)
        {
            await _context.DadosPessoais.AddAsync(dadosPessoa, ct);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<List<DadosPessoa>> GetAll()
        {
            return await _context.DadosPessoais.ToListAsync();
        }

        public async Task<DadosPessoa?> GetById(Guid id)
        {
            return await _context.DadosPessoais.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Remove(DadosPessoa dadosPessoa)
        {
            _context.DadosPessoais.Remove(dadosPessoa);
        }
    }
}
