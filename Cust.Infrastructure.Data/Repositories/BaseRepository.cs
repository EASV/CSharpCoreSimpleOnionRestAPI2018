namespace Cust.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository
    {
        protected CustomerAppDBContext _context;
        public BaseRepository(CustomerAppDBContext context)
        {
            _context = context;
        }
    }
}
