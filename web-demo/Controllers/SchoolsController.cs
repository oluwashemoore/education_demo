using System.Linq;
using web_demo.Data;
using web_demo.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace web_demo.Controllers
{
    public class SchoolsController : Controller
    {
        private readonly DatabaseContext _context;

        public SchoolsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Schools
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Schools.Include(s => s.InstitutionType).Include(s => s.State);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Schools/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.Schools
                .Include(s => s.InstitutionType)
                .Include(s => s.State)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // GET: Schools/Create
        public IActionResult Create()
        {
            ViewData["InstitutionTypeId"] = new SelectList(_context.InstitutionTypes, "ID", "ID");
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID");
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Address,Website,EmailAddress,ContactNumber,StateId,InstitutionTypeId")] School school)
        {
            if (ModelState.IsValid)
            {
                _context.Add(school);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InstitutionTypeId"] = new SelectList(_context.InstitutionTypes, "ID", "ID", school.InstitutionTypeId);
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID", school.StateId);
            return View(school);
        }

        // GET: Schools/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.Schools.FindAsync(id);
            if (school == null)
            {
                return NotFound();
            }
            ViewData["InstitutionTypeId"] = new SelectList(_context.InstitutionTypes, "ID", "ID", school.InstitutionTypeId);
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID", school.StateId);
            return View(school);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Address,Website,EmailAddress,ContactNumber,StateId,InstitutionTypeId")] School school)
        {
            if (id != school.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(school);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolExists(school.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["InstitutionTypeId"] = new SelectList(_context.InstitutionTypes, "ID", "ID", school.InstitutionTypeId);
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID", school.StateId);
            return View(school);
        }

        // GET: Schools/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.Schools
                .Include(s => s.InstitutionType)
                .Include(s => s.State)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var school = await _context.Schools.FindAsync(id);
            _context.Schools.Remove(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolExists(int id)
        {
            return _context.Schools.Any(e => e.ID == id);
        }
    }
}
