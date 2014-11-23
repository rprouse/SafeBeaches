using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using Newtonsoft.Json;
using SafeBeaches.Data;

namespace SafeBeaches.Models
{
    public class Beach
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonConverter( typeof( DbGeographyConverter ) )]
        public DbGeography Location { get; set; }

        public bool Safe { get; set; }
        public DateTime LastReadingDate { get; set; }

        public ICollection<Reading> Readings { get; set; }

        public Reading GetLatestReading()
        {
            var reading = Readings.OrderByDescending(r => r.Date).FirstOrDefault();
            return reading ?? new Reading {Date = DateTime.Now, Safe = false};
        }
    }
}
