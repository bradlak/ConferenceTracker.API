using ConferenceTracker.API.Entities;
using ConferenceTracker.API.Models;
using ConferenceTracker.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        private ILogger<SessionsController> logger;
        private GenericRepository<ConferenceTrackerContext, Session> repository;
        private GenericRepository<ConferenceTrackerContext, Speaker> speakersRepository;

        public SessionsController(ILogger<SessionsController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            repository = new GenericRepository<ConferenceTrackerContext, Session>(context);
            speakersRepository = new GenericRepository<ConferenceTrackerContext, Speaker>(context);
        }

        [HttpGet]
        public async Task<IActionResult> GetSessions()
        {
            var data = await repository.Get().Include("SpeakerSessions").ToListAsync();
            List<SessionDto> sessions = new List<SessionDto>();
            foreach (var item in data)
            {
                var session = new SessionDto(item);
                session.Speakers = speakersRepository.Get(z => item.SpeakerSessions.Select(x => x.SpeakerId).Contains(z.Id)).ToList().Select(z => new SpeakerDto(z));

                sessions.Add(session);
            }

            return Ok(sessions);
        }
    }
}
