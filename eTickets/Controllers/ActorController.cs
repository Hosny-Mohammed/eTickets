using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using eTickets.Data.Services;
namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorsService service;
        public ActorController(IActorsService _service)
        {
            service = _service; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AllActor() 
        {
            var actors = await service.GetAll();
            return View(actors);
        }
        public IActionResult ActorDetails(int id)
        {
            var actor = service.GetById(id);
            if (actor == null)
                return View("NotFound");
            return View(actor);
        }
        [HttpGet]
        public IActionResult ActorEdit(int id)
        {
            var actor = service.GetById(id);
            if (actor == null)
                return View("NotFound");
            return View(actor);
        }
        [HttpPost]
        public IActionResult ActorEdit(Actor actor)
        {

            if (ModelState.IsValid) 
            {
                service.Update(actor);
                return RedirectToAction("AllActor");
            }
            return View("NotFound");
        }
        public IActionResult RemoveActor(int id) 
        {
            var Actor = service.Delete(id);
            if (!Actor)
                return View("NotFound");
            return RedirectToAction("AllActor");
        }
        public IActionResult RedirectToAddActor()
        {
            return View("AddActor");
        }
        public IActionResult AddActor(Actor actor)
        {
            if (!ModelState.IsValid)
                return View("NotFound");
            service.Add(actor);
            return RedirectToAction("AllActor");
        }
        
    }
}  
