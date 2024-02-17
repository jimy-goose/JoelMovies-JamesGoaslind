using Microsoft.EntityFrameworkCore;

namespace JoelMovies_JamesGoaslind.Models
{
     public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options) 
        {
        }

        public DbSet<NewMovie> NewMovies { get; set; }
    }
}
