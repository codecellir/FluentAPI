using Microsoft.EntityFrameworkCore;

namespace FluentAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("STD");

            modelBuilder.Entity<Student>().Property(x => x.Name)
                .HasMaxLength(150);
        }
    }

}
