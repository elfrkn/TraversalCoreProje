using Microsoft.EntityFrameworkCore;

namespace SignalRApiForSql.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        {

        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
