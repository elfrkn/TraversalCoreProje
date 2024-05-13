using Microsoft.EntityFrameworkCore;

namespace SignalRApi.DAL
{
    public class Context :DbContext

    {
        public Context(DbContextOptions<Context> option) : base(option)
        {

        }
        public  DbSet<Visitor> Visitors { get; set; }

    }
}
