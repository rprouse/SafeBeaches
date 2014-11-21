using System.Collections.Generic;

namespace SafeBeaches.Models
{
    public class WaterBody
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Beach> Beaches { get; set; }
    }
}