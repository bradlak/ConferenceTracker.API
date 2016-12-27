﻿namespace ConferenceTracker.API.Entities
{
    public class Sponsor : BaseObject
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public SponsorLevel Level { get; set; }
    }
}
