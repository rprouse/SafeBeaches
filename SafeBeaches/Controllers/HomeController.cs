using System.Linq;
using System.Web.Mvc;
using SafeBeaches.Data;
using SafeBeaches.Models;

namespace SafeBeaches.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBeachesRepository _repo;

        public HomeController(IBeachesRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            IQueryable<Beach> beaches = _repo.GetBeaches();
            return View(beaches);
        }
    }
}
