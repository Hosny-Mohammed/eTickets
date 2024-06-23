using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        public readonly AppDbContext _context;
        public ActorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllActor() 
        {
            var actors = _context.Actors.ToList();
            return View(actors);
        }
    }
}
