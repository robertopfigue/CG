namespace CG.Infra.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly CgDbContext _context;

        public BaseRepository(CgDbContext context)
        {
            _context = context;
        }
    }
}
