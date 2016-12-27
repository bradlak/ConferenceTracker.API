using ConferenceTracker.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferenceTracker.API.FakeDatabase
{
    public class SessionsDataStore
    {
        public static SessionsDataStore Current { get; } = new SessionsDataStore();

        public List<SessionDto> Sessions { get; set; }

        public SessionsDataStore()
        {
            var speakers = SpeakersDataStore.Current.Speakers;

            Sessions = new List<SessionDto>()
            {
                new SessionDto()
                {
                   Id = 0,
                   Title = "About League of Legends",
                   Description = "Ashe vs Varus. Which bow is better?",
                   Start = DateTime.Now,
                   End = DateTime.Now.AddHours(2),
                   Speakers = speakers.Take(1).ToList()
                },
                new SessionDto()
                {
                   Id = 1,
                   Title = "How to backflip?",
                   Description = "Simple ways to do a flip without death",
                   Start = DateTime.Now.AddDays(1),
                   End = DateTime.Now.AddDays(1).AddHours(2),
                   Speakers = speakers.Take(2).ToList()
                },
                new SessionDto()
                {
                   Id = 2,
                   Title = "Sausages. Silent meat killer?",
                   Description = "About sausages and sausages with ketchup. Yes. I'am hungry while writing this.",
                   Start = DateTime.Now.AddHours(5),
                   End = DateTime.Now.AddHours(8),
                   Speakers = speakers.Take(3).ToList()
                }
            };

        }
    }
}
