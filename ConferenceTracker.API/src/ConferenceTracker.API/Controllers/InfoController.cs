using ConferenceTracker.API.Entities;
using ConferenceTracker.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        private ILogger<InfoController> logger;
        private GenericRepository<ConferenceTrackerContext, ConferenceInfo> repository;

        public InfoController(ILogger<InfoController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            repository = new GenericRepository<ConferenceTrackerContext, ConferenceInfo>(context);
        }

        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok(repository.Get().FirstOrDefault());
        }
    }
}
