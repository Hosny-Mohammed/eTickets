using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        public readonly AppDbContext context;
        public MovieController(AppDbContext _context) 
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View(context.Movies.ToList());
        }
    }
}
