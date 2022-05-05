namespace CG.Infra.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly CurriculoContext DbContext;

        public BaseRepository(CurriculoContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
