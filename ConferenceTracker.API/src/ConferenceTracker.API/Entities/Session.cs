using ConferenceTracker.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceTracker.API.Entities
{
    public class Session : BaseObject
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public ICollection<Speaker> Speakers { get; set; } = new List<Speaker>();
    }
}
