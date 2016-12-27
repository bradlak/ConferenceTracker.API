using ConferenceTracker.API.Entities;
using ConferenceTracker.API.FakeDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        private ILogger<SessionsController> logger;
        ConferenceTrackerContext db;

        public SessionsController(ILogger<SessionsController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            db = context;
        }

        [HttpGet]
        public IActionResult GetSessions()
        {
            logger.LogInformation("GetSessions executed");

            return Ok(SessionsDataStore.Current.Sessions);
        }
    }
}
