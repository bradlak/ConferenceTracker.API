using ConferenceTracker.API.Entities;
using ConferenceTracker.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class SponsorsController : Controller
    {
        private ILogger<SponsorsController> logger;
        private GenericRepository<ConferenceTrackerContext, Sponsor> repository;

        public SponsorsController(ILogger<SponsorsController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            repository = new GenericRepository<ConferenceTrackerContext, Sponsor>(context);
        }

        [HttpGet]
        public IActionResult GetSponsors()
        {
            return Ok(repository.Get());
        }
    }
}
