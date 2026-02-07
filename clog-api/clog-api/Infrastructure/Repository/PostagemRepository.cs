using clog_api.Infrastructure.Database;
using clog_api.Infrastructure.Repository.Interfaces;

namespace clog_api.Infrastructure.Repository
{
    public class PostagemRepository : IPostagemRepository
    {
        private readonly ApiDbContext _context;

        public PostagemRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}
