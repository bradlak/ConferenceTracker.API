using ConferenceTracker.API.Entities;
using ConferenceTracker.API.FakeDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class SponsorsController : Controller
    {
        private ILogger<SponsorsController> logger;
        ConferenceTrackerContext db;

        public SponsorsController(ILogger<SponsorsController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            db = context;
        }

        [HttpGet]
        public IActionResult GetSponsors()
        {
            logger.LogInformation("GetSponsors executed");

            return Ok(SponsorsDataStore.Current.Sponsors);
        }
    }
}
