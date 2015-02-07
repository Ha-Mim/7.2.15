using System.Data.Entity;

namespace MVCPractise.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
    
}