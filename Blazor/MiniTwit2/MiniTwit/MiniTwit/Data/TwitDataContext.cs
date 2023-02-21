using Microsoft.EntityFrameworkCore;

namespace MiniTwit.Data
{
    public class TwitDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public TwitDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("minitwit"));
            
        }

        public DbSet<Twit> twits { get; set; }
    }
}
