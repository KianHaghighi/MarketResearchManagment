using Microsoft.EntityFrameworkCore;

namespace MarketResearchManagment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MarketResearchManagment.Models.MarketMap> MarketMaps { get; set; }
    }
}
