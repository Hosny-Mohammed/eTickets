using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppDbContext context;
        public MoviesController(AppDbContext _context) 
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View(context.Movies.ToList());
        }
    }
}
