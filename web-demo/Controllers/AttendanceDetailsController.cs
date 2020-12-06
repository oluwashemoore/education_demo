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
    public class AttendanceDetailsController : Controller
    {
        private readonly DatabaseContext _context;

        public AttendanceDetailsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: AttendanceDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.AttendanceDetails.ToListAsync());
        }

        // GET: AttendanceDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendanceDetails = await _context.AttendanceDetails
                .FirstOrDefaultAsync(m => m.ID == id);
            if (attendanceDetails == null)
            {
                return NotFound();
            }

            return View(attendanceDetails);
        }

        // GET: AttendanceDetails/Create
        public async Task<IActionResult> Create(int? schoolId = 1)
        {
            ViewData["school"] = await _context.Schools.FirstOrDefaultAsync(m => m.ID == schoolId.Value);
            ViewData["students"] = await _context.Students.Where(m => m.SchoolId == schoolId.Value).ToListAsync();
            return View();
        }

        // POST: AttendanceDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Reason,Status")] AttendanceDetails attendanceDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attendanceDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(attendanceDetails);
        }

        // GET: AttendanceDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendanceDetails = await _context.AttendanceDetails.FindAsync(id);
            if (attendanceDetails == null)
            {
                return NotFound();
            }
            return View(attendanceDetails);
        }

        // POST: AttendanceDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Reason,Status")] AttendanceDetails attendanceDetails)
        {
            if (id != attendanceDetails.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attendanceDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttendanceDetailsExists(attendanceDetails.ID))
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
            return View(attendanceDetails);
        }

        // GET: AttendanceDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendanceDetails = await _context.AttendanceDetails
                .FirstOrDefaultAsync(m => m.ID == id);
            if (attendanceDetails == null)
            {
                return NotFound();
            }

            return View(attendanceDetails);
        }

        // POST: AttendanceDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attendanceDetails = await _context.AttendanceDetails.FindAsync(id);
            _context.AttendanceDetails.Remove(attendanceDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttendanceDetailsExists(int id)
        {
            return _context.AttendanceDetails.Any(e => e.ID == id);
        }
    }
}
