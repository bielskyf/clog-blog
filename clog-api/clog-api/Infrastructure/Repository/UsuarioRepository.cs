using clog_api.Infrastructure.Database;
using clog_api.Infrastructure.Repository.Interfaces;

namespace clog_api.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApiDbContext _context;

        public UsuarioRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}
