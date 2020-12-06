using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web_demo.Data;
using web_demo.Entities;

namespace web_demo.Controllers
{
    public class TeachersController : Controller
    {
        private readonly DatabaseContext _context;

        public TeachersController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Teachers.Include(t => t.CurrentSchool);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers
                .Include(t => t.CurrentSchool)
                .Include(t => t.TeacherSubject)
                    .ThenInclude(t => t.Subject)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // GET: Teachers/Create
        public async Task<IActionResult> Create()
        {
            ViewData["schools"] = await _context.Schools.ToListAsync();
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Address,LastName,FirstName,OtherNames,EmailAdress,CoontactNumber,CurrentSchoolId")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CurrentSchoolId"] = new SelectList(_context.Schools, "ID", "ID", teacher.CurrentSchoolId);
            return View(teacher);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Address,LastName,FirstName,OtherNames,EmailAdress,CoontactNumber,CurrentSchoolId")] Teacher teacher, int[] subjectsIds)
        {
            if (id != teacher.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    teacher.TeacherSubject = new List<TeacherSubject>();
                    foreach (var item in subjectsIds)
                    {
                        teacher.TeacherSubject.Add(new TeacherSubject
                        {
                            SubjectId = item,
                        });
                    }
                    _context.Update(teacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherExists(teacher.ID))
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
            ViewData["CurrentSchoolId"] = new SelectList(_context.Schools, "ID", "ID", teacher.CurrentSchoolId);
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teachers
                .Include(t => t.CurrentSchool)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherExists(int id)
        {
            return _context.Teachers.Any(e => e.ID == id);
        }
    }
}
