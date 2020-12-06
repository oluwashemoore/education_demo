using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web_demo.Data;
using web_demo.Entities;
using web_demo.Models;

namespace web_demo.Controllers
{
    public class AttendancesController : Controller
    {
        private readonly DatabaseContext _context;

        public AttendancesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Attendances
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Attendance.Include(a => a.AttendanceDetails).Include(a => a.School).Include(a => a.Subject);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Attendances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendance = await _context.Attendance
                .Include(a => a.AttendanceDetails)
                    .ThenInclude(a => a.Student)
                .Include(a => a.School)
                .Include(a => a.Subject)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (attendance == null)
            {
                return NotFound();
            }

            return View(attendance);
        }

        // GET: Attendances/Create
        public IActionResult Create_old()
        {
            ViewData["AttendanceDetailsId"] = new SelectList(_context.Set<AttendanceDetails>(), "ID", "ID");
            ViewData["SchoolId"] = new SelectList(_context.Schools, "ID", "ID");
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Id");
            return View();
        }

        // GET: Attendances/Create
        public async Task<IActionResult> Create()
        {
            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["students"] = await _context.Students.ToListAsync();
            return View();
        }

        // POST: Attendances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,SchoolId,SubjectId")] AttendanceModel attendance, int[] studentId, bool[] status)
        {
            Attendance a = new Attendance
            {
                Date = DateTime.Now,
                SchoolId = attendance.SchoolId,
                SubjectId = attendance.SubjectId,
            };

            int counter = 0;
            a.AttendanceDetails = new List<AttendanceDetails>();
            foreach (var student in studentId)
            {
                a.AttendanceDetails.Add(  new AttendanceDetails
                {
                    StudentId = student,
                    Status = status[counter]
                });
                counter++;
            }

            _context.Add(a);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
        private bool AttendanceExists(int id)
        {
            return _context.Attendance.Any(e => e.ID == id);
        }
    }
}
