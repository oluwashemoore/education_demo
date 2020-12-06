using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_demo.Data;
using web_demo.Entities;
using web_demo.Model;

namespace web_demo.Controllers
{
    public class ReportsController : Controller
    {

        private readonly DatabaseContext _context;

        public ReportsController(DatabaseContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Attendance()
        {
            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            ViewData["schools"] = await _context.Schools.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Attendance([Bind("From, To, SchoolId, SubjectId")]AttendanceReportViewModel model)
        {
            ViewData["data"] = "data";
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            ViewData["students"] = await _context.Students/*.Where(x => x.SchoolId == model.SchoolId)*/.ToListAsync();
            ViewData["attendances"] =  await _context.Attendance.Include(x => x.AttendanceDetails)
                                            .Where(x => x.SchoolId == model.SchoolId && x.SubjectId == model.SubjectId && 
                                            x.Date >= model.From && x.Date <= model.To).ToListAsync();
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Academics()
        {
            ViewData["periods"] = await _context.AcademicPeriods.ToListAsync();
            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Academics([Bind("PeriodId, SubjectId")]AcademicReportViewModel model)
        {

            ViewData["periods"] = await _context.AcademicPeriods.ToListAsync();
            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            ViewData["data"] = model.SubjectId.ToString();
            return View();
        }


        [HttpGet]
        public async Task<ActionResult> idcards()
        {
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["students"] = await _context.Students.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> idcards([Bind("SchoolId, StudentId")]IdCardReportViewModel model)
        {
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["students"] = await _context.Students.ToListAsync();
            Student student = await _context.Students.Include(x => x.School).Include(x => x.Class).SingleOrDefaultAsync(x => x.ID == model.StudentId);
            return View(student);
        }

        // POST: Reports/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reports/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reports/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reports/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reports/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

    public class IdCardReportViewModel
    {
        public int SchoolId { get; set; }
        public int StudentId { get; set; }
    }

    public class AcademicReportViewModel
    {
        public int PeriodId { get; set; }
        public int SubjectId { get; set; }
    }
}