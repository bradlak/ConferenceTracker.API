namespace ConferenceTracker.API.Entities
{
    public class SpeakerSession : BaseEntity
    {
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
