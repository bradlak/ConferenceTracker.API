using ConferenceTracker.API.Entities;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace ConferenceTracker.API.Models
{
    public class SpeakerDto
    {
        public SpeakerDto(Speaker speaker)
        {
            this.Id = speaker.Id;
            this.FirstName = speaker.FirstName;
            this.LastName = speaker.LastName;
            this.Company = speaker.Company;
            this.Description = speaker.Description;
            this.FacebookUrl = speaker.FacebookUrl;
            this.GithubUrl = speaker.GithubUrl;
            this.TwitterUrl = speaker.TwitterUrl;
            this.PhotoUrl = speaker.PhotoUrl;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

        public string Description { get; set; }

        public string PhotoUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string TwitterUrl { get; set; }

        public string GithubUrl { get; set; }
    }
}
