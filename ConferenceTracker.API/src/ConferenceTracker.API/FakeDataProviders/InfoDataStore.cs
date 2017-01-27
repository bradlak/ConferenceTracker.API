using ConferenceTracker.API.Entities;

namespace ConferenceTracker.API.FakeDataProviders
{
    public class InfoDataStore
    {
        public static InfoDataStore Current { get; } = new InfoDataStore();

        public ConferenceInfo Info { get; set; }

        public InfoDataStore()
        {
            Info = new ConferenceInfo()
            {
                Info = "Konferencja taka super. Wow!"
            };
        }
    }
}
