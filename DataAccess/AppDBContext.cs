using APIpeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace APIpeliculas.DataAccess
{
    public class AppDBContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genero> Generos { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {
            
        }
    }


}
