using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SafeBeaches.Data;
using SafeBeaches.Models;

namespace SafeBeaches.Controllers
{
    public class WaterBodiesController : ApiController
    {
        private readonly IBeachesRepository _repo;

        public WaterBodiesController(IBeachesRepository repo)
        {
            _repo = repo;
        }

        // GET: api/WaterBodies
        public IEnumerable<WaterBody> Get()
        {
            return _repo.GetWaterBodies();
        }

        // GET: api/WaterBodies/5
        public WaterBody Get( int id )
        {
            return _repo.GetWaterBodies( ).FirstOrDefault(w => w.Id == id);
        }
    }
}
