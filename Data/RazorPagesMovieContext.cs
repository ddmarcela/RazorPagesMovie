using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
         public DbSet<RazorPagesMovie.Models.Movie> Future { get; set; }
         public DbSet<RazorPagesMovie.Models.Future> Future_1 { get; set; }
    }
}