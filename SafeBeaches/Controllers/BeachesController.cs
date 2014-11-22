using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SafeBeaches.Data;
using SafeBeaches.Models;

namespace SafeBeaches.Controllers
{
    public class BeachesController : ApiController
    {
        private readonly IBeachesRepository _repo;

        public BeachesController(IBeachesRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Beaches
        /// <summary>
        /// Gets all of the beaches in the Hamilton area along with their recent readings
        /// </summary>
        /// <returns>A list of all the beaches</returns>
        public IEnumerable<Beach> Get()
        {
            return _repo.GetBeaches();
        }

        // GET: api/Beaches/5
        /// <summary>
        /// Gets a specific beach and all of it's water quality readings
        /// </summary>
        /// <param name="id">The ID of the beach</param>
        /// <returns>The requested beach</returns>
        public Beach Get( int id )
        {
            return _repo.GetBeaches().FirstOrDefault(b => b.Id == id);
        }
    }
}
