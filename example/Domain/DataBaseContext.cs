using System.Data.Entity;

namespace example.Domain
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}