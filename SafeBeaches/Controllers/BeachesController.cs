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
        public IEnumerable<Beach> Get()
        {
            return _repo.GetBeaches();
        }

        // GET: api/Beaches/5
        public Beach Get( int id )
        {
            return _repo.GetBeaches().FirstOrDefault(b => b.Id == id);
        }
    }
}
