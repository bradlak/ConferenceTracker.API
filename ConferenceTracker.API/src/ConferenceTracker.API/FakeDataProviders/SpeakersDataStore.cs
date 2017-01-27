using ConferenceTracker.API.Entities;
using ConferenceTracker.API.Models;
using System.Collections.Generic;

namespace ConferenceTracker.API.FakeDataProviders
{
    public class SpeakersDataStore
    {
        public static SpeakersDataStore Current { get; } = new SpeakersDataStore();

        public List<Speaker> Speakers { get; set; }
        
        public SpeakersDataStore()
        {
            Speakers = new List<Speaker>()
            {
                new Speaker()
                {
                    FirstName = "Adam",
                    LastName = "Małysz",
                    Company = "Skok",
                    Description = "Znany skoczek narciarski.",
                    PhotoUrl = "http://static.berkutschi.com/berkutschi/images/news/000/002/659/thumb500/s_508.jpg"
                },
                new Speaker()
                {
                    FirstName = "Pan",
                    LastName = "Józek",
                    Company = "Chicken.inc",
                    Description = "Hodowca drobiu.",
                    PhotoUrl = "http://bi.gazeta.pl/im/3/10904/z10904573Q,Grzegorz-Halama-facebook-com.jpg"
                },
                new Speaker()
                {
                    FirstName = "Isaac",
                    LastName = "Newton",
                    Company = "Gravity corp.",
                    Description = "Dostał jabłkiem i przyszedł.",
                    PhotoUrl = "http://cdn8.openculture.com/wp-content/uploads/2015/03/30193908/isaac-newton-list-of-sins.jpg"
                }
            };
        }
    }
}
