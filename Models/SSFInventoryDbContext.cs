using Microsoft.EntityFrameworkCore;

namespace SSFInventory.Models
{
    public class SSFInventoryDbContext : DbContext
    {
        public SSFInventoryDbContext(DbContextOptions<SSFInventoryDbContext> options):base(options)
        {

        }
        public DbSet<Categories> Categories{ get; set; }
    }
}
