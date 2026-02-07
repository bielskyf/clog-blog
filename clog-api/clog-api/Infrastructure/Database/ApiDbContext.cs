using Microsoft.EntityFrameworkCore;
using clog_api.Models;

namespace clog_api.Infrastructure.Database
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApiDbContext()
        {
        }

        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Nicho> Nichos { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
