using Microsoft.EntityFrameworkCore;

namespace Aniflix.Data
{
    public class FilmesContext : DbContext
    {
        public DbSet<FilmesContext> Filmes { get; set; }

        // onconfiguring postgresql username OverHung6393
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Aniflix;User Id=postgres;Password=OverHung6393;");
        }

    }


}
