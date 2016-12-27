using ConferenceTracker.API.Models;
using System.Collections.Generic;

namespace ConferenceTracker.API.FakeDatabase
{
    public class SpeakersDataStore
    {
        public static SpeakersDataStore Current { get; } = new SpeakersDataStore();

        public List<SpeakerDto> Speakers { get; set; }
        
        public SpeakersDataStore()
        {
            Speakers = new List<SpeakerDto>()
            {
                new SpeakerDto()
                {
                    Id = 0,
                    FirstName = "Adam",
                    LastName = "Małysz",
                    Company = "Skok",
                    Description = "Znany skoczek narciarski.",
                    PhotoUrl = "http://static.berkutschi.com/berkutschi/images/news/000/002/659/thumb500/s_508.jpg"
                },
                new SpeakerDto()
                {
                    Id = 1,
                    FirstName = "Pan",
                    LastName = "Józek",
                    Company = "Chicken.inc",
                    Description = "Hodowca drobiu",
                    PhotoUrl = "http://bi.gazeta.pl/im/3/10904/z10904573Q,Grzegorz-Halama-facebook-com.jpg"
                }
            };
        }
    }
}
