using ConferenceTracker.API.Entities;
using ConferenceTracker.API.FakeDatabase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceTracker.API.Controllers
{
    [Route("api/[controller]")]
    public class InfoController : Controller
    {
        private ILogger<InfoController> logger;
        ConferenceTrackerContext db;

        public InfoController(ILogger<InfoController> logger, ConferenceTrackerContext context)
        {
            this.logger = logger;
            db = context;
        }

        [HttpGet]
        public IActionResult GetInfo()
        {
            logger.LogInformation("GetInfo executed");

            return Ok(InfoDataStore.Current.Info);
        }
    }
}
