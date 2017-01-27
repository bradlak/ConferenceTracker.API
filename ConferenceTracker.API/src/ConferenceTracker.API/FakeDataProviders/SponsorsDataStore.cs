using ConferenceTracker.API.Entities;
using System.Collections.Generic;

namespace ConferenceTracker.API.FakeDataProviders
{
    public class SponsorsDataStore
    {
        public static SponsorsDataStore Current { get; } = new SponsorsDataStore();

        public List<Sponsor> Sponsors { get; set; }

        public SponsorsDataStore()
        {
            Sponsors = new List<Sponsor>()
            {
                    new Sponsor()
                    {
                       ImageUrl = @"http://www.valuewalk.com/wp-content/uploads/2013/01/Audience-Logo.jpg",
                       Name = "Audience",
                       Level = SponsorLevel.Gold
                    },
                    new Sponsor()
                    {
                        ImageUrl = @"http://img13.deviantart.net/0dab/i/2010/230/b/e/aperture_laboratories_stencil_by_chrisinvt.png",
                        Name = "Aperture Laboratories",
                        Level = SponsorLevel.Silver
                    },
            };
        }
    }
}
