using web_demo.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace web_demo.Controllers
{
    public class PerformanceController : Controller
    {
        private readonly DatabaseContext _context;

        public PerformanceController(DatabaseContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            ViewData["students"] = await _context.Students.ToListAsync();
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["periods"] = await _context.AcademicPeriods.ToListAsync();
            return View();

        }


        public async Task<IActionResult> Create()
        {
            return View();

        }
    }
}