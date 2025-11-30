using Linca_David_Lab4_MasterEB.Models;
using Microsoft.EntityFrameworkCore;
namespace Linca_David_Lab4_MasterEB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<PredictionHistory> PredictionHistories { get; set; }
    }
}
