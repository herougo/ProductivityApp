using Microsoft.EntityFrameworkCore;
using ProductivityApp.Core.Data.Models;

namespace ProductivityApp.Core.Data
{
    public class DataDbContext : DbContext
    {
        public string DbPath { get; }

        public DataDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            string path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "productivity.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        public DbSet<ButtonClicks> Question { get; set; } = null!;
    }
}
