using ConferenceTracker.API.Entities;
using ConferenceTracker.API.Models;
using System.Collections.Generic;

namespace ConferenceTracker.API.FakeDatabase
{
    public class SponsorsDataStore
    {
        public static SponsorsDataStore Current { get; } = new SponsorsDataStore();

        public List<SponsorDto> Sponsors { get; set; }

        public SponsorsDataStore()
        {
            Sponsors = new List<SponsorDto>()
            {
                    new SponsorDto()
                    {
                       Id = 0,
                       ImageUrl = @"http://www.mcwade.com/DesignTalk/wp-content/uploads/2009/02/pepsilogowtext1.jpg",
                       Name = "Pepsi Company",
                       Level = SponsorLevel.Gold
                    },
                    new SponsorDto()
                    {
                        Id = 1,
                        ImageUrl = @"http://www.parabolicarc.com/wp-content/uploads/2009/04/boeing_logo.jpg",
                        Name = "Boeing",
                        Level = SponsorLevel.Silver
                    },
            };
        }
    }
}
