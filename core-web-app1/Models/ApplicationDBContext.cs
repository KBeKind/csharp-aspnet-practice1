using Microsoft.EntityFrameworkCore;

namespace core_web_app1.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=core_web_app1;User=newuser;Password=newuser",
                 new MySqlServerVersion(new Version(8, 0, 33)));
        }
    }
}
