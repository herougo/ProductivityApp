using Microsoft.EntityFrameworkCore;
using ProductivityApp.Core.Data.Models;

namespace ProductivityApp.Core.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options)
            : base(options)
        { }

        public DbSet<ButtonClicks> Question { get; set; } = null!;
    }
}
