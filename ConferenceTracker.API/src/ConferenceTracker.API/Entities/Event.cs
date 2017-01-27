using System;

namespace ConferenceTracker.API.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}
