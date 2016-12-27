using ConferenceTracker.API.Entities;
using System.Collections.Generic;

namespace ConferenceTracker.API.Models
{
    public class SessionDto : Session
    {
        public new ICollection<SpeakerDto> Speakers { get; set; } = new List<SpeakerDto>();
    }
}
