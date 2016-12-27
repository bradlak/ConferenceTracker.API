using Microsoft.EntityFrameworkCore;

namespace ConferenceTracker.API.Entities
{
    public class ConferenceTrackerContext : DbContext
    {
        public ConferenceTrackerContext(DbContextOptions<ConferenceTrackerContext> opt) 
            : base(opt)
        {
            Database.Migrate();
        }

        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "secret";
            optionsBuilder.UseSqlServer(conn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
