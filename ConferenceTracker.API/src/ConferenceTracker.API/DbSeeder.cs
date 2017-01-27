using ConferenceTracker.API.Entities;
using ConferenceTracker.API.FakeDataProviders;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ConferenceTracker.API
{
    public static class DbSeeder
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetService<ConferenceTrackerContext>();

            db.Info.Add(InfoDataStore.Current.Info);
            db.Events.AddRange(EventsDataStore.Current.Events);
            db.Sessions.AddRange(SessionsDataStore.Current.Sessions);
            db.Speakers.AddRange(SpeakersDataStore.Current.Speakers);
            db.Sponsors.AddRange(SponsorsDataStore.Current.Sponsors);

            db.SaveChanges();

            db.SpeakerSessions.Add(new SpeakerSession()
            {
                SessionId = db.Sessions.First().Id,
                SpeakerId = db.Speakers.First().Id,
            });

            db.SpeakerSessions.Add(new SpeakerSession()
            {
                SessionId = db.Sessions.Skip(1).First().Id,
                SpeakerId = db.Speakers.Last().Id,
            });

            db.SpeakerSessions.Add(new SpeakerSession()
            {
                SessionId = db.Sessions.Last().Id,
                SpeakerId = db.Speakers.Skip(1).First().Id,
            });

            db.SpeakerSessions.Add(new SpeakerSession()
            {
                SessionId = db.Sessions.First().Id,
                SpeakerId = db.Speakers.Last().Id,
            });

            db.SaveChanges();
        }
    }
}
