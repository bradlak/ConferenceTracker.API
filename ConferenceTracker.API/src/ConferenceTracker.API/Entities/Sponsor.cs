namespace ConferenceTracker.API.Entities
{
    public class Sponsor : BaseEntity
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public SponsorLevel Level { get; set; }
    }
}
