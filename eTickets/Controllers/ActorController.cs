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
        public IActionResult ActorDetails(int id)
        {
            id = 1;
            var actor = _context.Actors.FirstOrDefault(a => a.ActorId == id);
            if (actor == null)
                return View("Not Found");
            return View(actor); 
        }
        
    }
}  
