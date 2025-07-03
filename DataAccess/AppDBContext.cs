using APIpeliculas.Models;
using Microsoft.EntityFrameworkCore;
using APIpeliculas.Seeder;

namespace APIpeliculas.DataAccess
{
    public class AppDBContext:DbContext //conexiona la base de datos
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genero> Generos { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(m => m.Titulo)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Movie>().HasIndex(m => m.Titulo).IsUnique();
            modelBuilder.Entity<Movie>().Property(m => m.Description).HasMaxLength(500);
            modelBuilder.Entity<Movie>().HasData(Seeder.Seeder.Movie);
            modelBuilder.Entity<Genero>().HasData(Seeder.Seeder.Genero);
            base.OnModelCreating(modelBuilder);
        }
    }


}
