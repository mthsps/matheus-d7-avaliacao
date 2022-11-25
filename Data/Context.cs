using LoginApp.Model;
using Microsoft.EntityFrameworkCore;

namespace LoginApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }

    }
}
