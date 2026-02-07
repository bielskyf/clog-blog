using clog_api.Infrastructure.Database;
using clog_api.Infrastructure.Repository.Interfaces;

namespace clog_api.Infrastructure.Repository
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly ApiDbContext _context;

        public ComentarioRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}
