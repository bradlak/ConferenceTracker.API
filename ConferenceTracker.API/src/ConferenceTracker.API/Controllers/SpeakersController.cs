using ConferenceTracker.API.Entities;
using ConferenceTracker.API.FakeDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class SpeakersController : Controller
    {
        private ILogger<SpeakersController> logger;
        ConferenceTrackerContext db;

        public SpeakersController(ILogger<SpeakersController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            db = context;
        }

        [HttpGet]
        public IActionResult GetSpeakers()
        {
            logger.LogInformation("GetSpeakers executed");

            return Ok(SpeakersDataStore.Current.Speakers);
        }

        [Route("{id}")]
        public IActionResult GetSpeakerById(int id)
        {
            logger.LogInformation("GetSpeakerById executed");

            return Ok(SpeakersDataStore.Current.Speakers.FirstOrDefault(z => z.Id == id));
        }
    }
}
