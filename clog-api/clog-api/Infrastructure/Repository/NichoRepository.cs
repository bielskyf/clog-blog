using clog_api.Infrastructure.Database;
using clog_api.Infrastructure.Repository.Interfaces;

namespace clog_api.Infrastructure.Repository
{
    public class NichoRepository : INichoRepository
    {
        private readonly ApiDbContext _context;

        public NichoRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}
