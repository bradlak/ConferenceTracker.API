using ConferenceTracker.API.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConferenceTracker.API.Models
{
    public class SessionDto
    {
        public SessionDto(Session session)
        {
            this.Description = session.Description;
            this.End = session.End;
            this.Id = session.Id;
            this.Start = session.Start;
            this.Title = session.Title;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public IEnumerable<SpeakerDto> Speakers { get; set; }
    }
}
