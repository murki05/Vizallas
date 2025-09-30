using Microsoft.EntityFrameworkCore;

namespace Vizallas.Data
{
    public class VizallasDbContext : DbContext
    {
        public VizallasDbContext(DbContextOptions<VizallasDbContext> options) : base(options)
        {
        }
        public DbSet<Model.Class> Classes { get; set; }
    }
}
