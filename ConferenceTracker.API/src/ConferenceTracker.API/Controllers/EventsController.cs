using ConferenceTracker.API.Entities;
using ConferenceTracker.API.FakeDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private ILogger<EventsController> logger;
        ConferenceTrackerContext db;

        public EventsController(ILogger<EventsController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            db = context;           
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            logger.LogInformation("GetEvents executed");

            return Ok(EventsDataStore.Current.Events);
        }
    }
}
