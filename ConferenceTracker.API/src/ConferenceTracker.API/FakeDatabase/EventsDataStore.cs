using ConferenceTracker.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceTracker.API.FakeDatabase
{
    public class EventsDataStore
    {
        public static EventsDataStore Current { get; } = new EventsDataStore();

        public List<EventDto> Events { get; set; }

        public EventsDataStore()
        {
            Events = new List<EventDto>()
            {
                new EventDto()
                {
                    Id = 1,
                    Description = "Funny",
                    Title = "Tomato throwing",
                    Start = new DateTime(2016,11,8,11,00,00),
                    End = new DateTime(2016,11,8,14,00,00)
                },
                new EventDto()
                {
                    Id = 2,
                    Description = "West world",
                    Title = "Funny stories",
                    Start = new DateTime(2016,11,9,9,00,00),
                    End = new DateTime(2016,11,9,11,00,00)
                },
                new EventDto()
                {
                    Id = 3,
                    Description = "Heheszki",
                    Title = "Heheszki",
                    Start = new DateTime(2016,11,12,9,00,00),
                    End = new DateTime(2016,11,12,11,00,00)
                },
            };
        }
    }
}
