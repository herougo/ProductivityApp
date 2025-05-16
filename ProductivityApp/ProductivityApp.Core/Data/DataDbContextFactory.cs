using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProductivityApp.Core.Data
{
    public class DataDbContextFactory : IDesignTimeDbContextFactory<DataDbContext>
    {
        public DataDbContext CreateDbContext(string[] args)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            string path = Environment.GetFolderPath(folder);
            string dbPath = Path.Join(path, "productivity.db");

            var optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new DataDbContext(optionsBuilder.Options);
        }
    }
}