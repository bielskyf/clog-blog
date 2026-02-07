using clog_api.Infrastructure.Database;
using clog_api.Infrastructure.Repository.Interfaces;

namespace clog_api.Infrastructure.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ApiDbContext _context;

        public PostRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}
