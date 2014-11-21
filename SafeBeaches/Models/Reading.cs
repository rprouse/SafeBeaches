using System;

namespace SafeBeaches.Models
{
    public class Reading
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Safe { get; set; }

        public int BeachId { get; set; }
    }
}