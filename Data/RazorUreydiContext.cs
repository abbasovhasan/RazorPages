using GoreyRazorNedi.Models;
using Microsoft.EntityFrameworkCore;

namespace GoreyRazorNedi.Data
{
    public class RazorUreydiContext : DbContext
    {
        public RazorUreydiContext(DbContextOptions<RazorUreydiContext> options)
            : base(options)
        {
        }

        public DbSet<GoreyRazorNedi.Models.Movie> Movie { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-ALE5B86;database=RazorNedi;Integrated Security=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
