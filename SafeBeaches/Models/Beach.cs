using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace SafeBeaches.Models
{
    public class Beach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DbGeography Location { get; set; }

        public bool Safe { get; set; }
        public DateTime LastReadingDate { get; set; }

        public int WaterBodyId { get; set; }

        public ICollection<Reading> Readings { get; set; }
    }
}
