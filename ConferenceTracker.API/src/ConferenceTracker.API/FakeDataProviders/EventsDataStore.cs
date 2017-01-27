using ConferenceTracker.API.Entities;
using System;
using System.Collections.Generic;

namespace ConferenceTracker.API.FakeDataProviders
{
    public class EventsDataStore
    {
        public static EventsDataStore Current { get; } = new EventsDataStore();

        public List<Event> Events { get; set; }

        public EventsDataStore()
        {
            Events = new List<Event>()
            {
                new Event()
                {
                    Description = "Jedzenie pizzy na czas",
                    Title = "Pizza",
                    Start = new DateTime(2016,11,8,11,00,00),
                    End = new DateTime(2016,11,8,14,00,00)
                },
                new Event()
                {
                    Description = "Czyli wytrzymaj piosenkę",
                    Title = "Moby Flower",
                    Start = new DateTime(2016,11,9,9,00,00),
                    End = new DateTime(2016,11,9,11,00,00)
                },
                new Event()
                {
                    Description = "Trzecia kawa? Nie ma sprawy.",
                    Title = "Kawa",
                    Start = new DateTime(2016,11,12,9,00,00),
                    End = new DateTime(2016,11,12,11,00,00)
                },
            };
        }
    }
}
