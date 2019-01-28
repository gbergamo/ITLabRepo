using ITLabTest.Model;
using Microsoft.EntityFrameworkCore;

namespace ITLabTest.SqlServer.EFCore.Context
{
    public class EfCoreDbContext: DbContext
    {
        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options): base(options)
        {

        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
