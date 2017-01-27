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

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<ConferenceInfo> Info { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

        public DbSet<SpeakerSession> SpeakerSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpeakerSession>()
                .HasOne(z => z.Speaker)
                .WithMany(s => s.SpeakerSessions)
                .HasForeignKey(ss => ss.SpeakerId);

            modelBuilder.Entity<SpeakerSession>()
                .HasOne(z => z.Session)
                .WithMany(s => s.SpeakerSessions)
                .HasForeignKey(ss => ss.SessionId);
        }
    }
}
