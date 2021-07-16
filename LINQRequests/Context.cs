using Microsoft.EntityFrameworkCore;

namespace LINQRequests
{
    public class Context:DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Lion> Lions { get; set; }
        public DbSet<Zebra> Zebras { get; set; }
        public DbSet<Giraffe> Giraffes { get; set; }
        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UAL9MA7\SQLEXPRESS;Database=LINQ;Trusted_Connection=True;");
        }
    }
}
