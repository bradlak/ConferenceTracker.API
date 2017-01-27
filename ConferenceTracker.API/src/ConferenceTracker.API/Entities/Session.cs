using System;
using System.Collections.Generic;

namespace ConferenceTracker.API.Entities
{
    public class Session : BaseEntity
    {
        public Session()
        {
            SpeakerSessions = new List<SpeakerSession>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public virtual ICollection<SpeakerSession> SpeakerSessions { get; set; }
    }
}
