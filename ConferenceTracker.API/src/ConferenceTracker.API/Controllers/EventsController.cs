using ConferenceTracker.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConferenceTracker.API.Repositories;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private ILogger<EventsController> logger;
        private GenericRepository<ConferenceTrackerContext, Event> repository;

        public EventsController(ILogger<EventsController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            repository = new GenericRepository<ConferenceTrackerContext, Event>(context);
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(repository.Get());
        }
    }
}
