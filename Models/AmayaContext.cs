using Microsoft.EntityFrameworkCore;

namespace Amaya
{
  public class AmayaContext : DbContext
  {
         public DbSet<NewCustomers> NewCustomers{ get; set; }

        public AmayaContext(DbContextOptions options) : base(options) { }
  }
}
