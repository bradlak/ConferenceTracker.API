using System.Collections.Generic;

namespace ConferenceTracker.API.Entities
{
    public class Speaker : BaseEntity
    {
        public Speaker()
        {
            SpeakerSessions = new List<SpeakerSession>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string TwitterUrl { get; set; }

        public string GithubUrl { get; set; }

        public virtual ICollection<SpeakerSession> SpeakerSessions { get; set; }
    }
}
