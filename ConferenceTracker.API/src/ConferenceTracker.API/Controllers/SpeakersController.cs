using ConferenceTracker.API.Entities;
using ConferenceTracker.API.Models;
using ConferenceTracker.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class SpeakersController : Controller
    {
        private ILogger<SpeakersController> logger;
        private GenericRepository<ConferenceTrackerContext, Speaker> repository;

        public SpeakersController(ILogger<SpeakersController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            repository = new GenericRepository<ConferenceTrackerContext, Speaker>(context);
        }

        [HttpGet]
        public IActionResult GetSpeakers()
        {
            return Ok(repository.Get().ToList().Select(z=> new SpeakerDto(z)));
        }

        [Route("{id}")]
        public IActionResult GetSpeakerById(int id)
        {
            return Ok(new SpeakerDto(repository.GetSingle(z=> z.Id == id)));
        }
    }
}
