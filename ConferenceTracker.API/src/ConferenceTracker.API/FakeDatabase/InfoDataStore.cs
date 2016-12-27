using ConferenceTracker.API.Entities;

namespace ConferenceTracker.API.FakeDatabase
{
    public class InfoDataStore
    {
        public static InfoDataStore Current { get; } = new InfoDataStore();

        public ConferenceInfo Info { get; set; }

        public InfoDataStore()
        {
            Info = new ConferenceInfo()
            {
                Id = 1,
                Info = "Super konferencja a ten opis to z InfoDataStore'a"
            };
        }
    }
}
