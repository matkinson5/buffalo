using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;

namespace buffalo.Models
{
    public class BuffaloContext : DbContext
    {
        public BuffaloContext() { }

        public BuffaloContext(DbContextOptions<BuffaloContext> options)
            : base(options)
        {
        }

        public DbSet<BurialMain> Burials { get; set; }

    }
}
