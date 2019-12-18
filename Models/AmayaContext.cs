using Microsoft.EntityFrameworkCore;

namespace Amaya
{
  public class AmayaContext : DbContext
  {
        //  public DbSet<PayModelView> PayModelViews{ get; set; }

        public AmayaContext(DbContextOptions options) : base(options) { }
  }
}
