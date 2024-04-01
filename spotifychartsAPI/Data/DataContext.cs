using spotifychartsAPI.Models;

namespace spotifychartsAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Charts> GlobalDailyChart { get; set; }
    }
}
