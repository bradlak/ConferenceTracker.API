using ConferenceTracker.API.Entities;
using System;
using System.Collections.Generic;

namespace ConferenceTracker.API.FakeDataProviders
{
    public class SessionsDataStore
    {
        public static SessionsDataStore Current { get; } = new SessionsDataStore();

        public List<Session> Sessions { get; set; }

        public SessionsDataStore()
        {
            var speakers = SpeakersDataStore.Current.Speakers;

            Sessions = new List<Session>()
            {
                new Session()
                {
                   Title = "Ashe i League of Legends",
                   Description = "Jak strzelać z lodowego łuku?",
                   Start = DateTime.Now,
                   End = DateTime.Now.AddHours(2),
                },
                new Session()
                {
                   Title = "Jak zrobić salto?",
                   Description = "Kilka sposobów jak zrobić salto i nie umrzeć.",
                   Start = DateTime.Now.AddDays(1),
                   End = DateTime.Now.AddDays(1).AddHours(2),
                },
                new Session()
                {
                   Title = "Parówki. Cichy zabójca?",
                   Description = "O parówkach z ketchupem.",
                   Start = DateTime.Now.AddHours(5),
                   End = DateTime.Now.AddHours(8),
                }
            };

        }
    }
}
