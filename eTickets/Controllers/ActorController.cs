using eTickets.Data;
using eTickets.Models;
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
            var actor = _context.Actors.FirstOrDefault(a => a.ActorId == id);
            if (actor == null)
                return View("Not Found");
            return View(actor);
        }
        [HttpGet]
        public IActionResult ActorEdit(int id)
        {
            var actor = _context.Actors.FirstOrDefault(a => a.ActorId == id);
            if (actor == null)
                return View("Not Found");
            return View(actor);
        }
        [HttpPost]
        public IActionResult ActorEdit(Actor actor)
        {
            if (!ModelState.IsValid) 
            {
                _context.Actors.Update(actor);
                _context.SaveChanges();
                return RedirectToAction("AllActor");
            }
            return View("Data's Not Valid");
        }
    }
}  
