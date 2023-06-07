using Microsoft.EntityFrameworkCore;

namespace MurilloCamachoProyecto.Models
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<genero> generos { get; set; }
    }
}
