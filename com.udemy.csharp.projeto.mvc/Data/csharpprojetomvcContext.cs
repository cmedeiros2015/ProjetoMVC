using Microsoft.EntityFrameworkCore;

namespace com.udemy.csharp.projeto.mvc.Models
{
    public class csharpprojetomvcContext : DbContext
    {
        public csharpprojetomvcContext (DbContextOptions<csharpprojetomvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
