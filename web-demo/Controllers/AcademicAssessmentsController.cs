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
    public class AcademicAssessmentsController : Controller
    {
        private readonly DatabaseContext _context;

        public AcademicAssessmentsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: AcademicAssessments
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.AcademicAssessments.Include(a => a.AcademicPeriod).Include(a => a.School).Include(a => a.AssessmentType).Include(a => a.Subject);
            return View(await databaseContext.ToListAsync());
        }

        // GET: AcademicAssessments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicAssessment = await _context.AcademicAssessments
                .Include(a => a.AcademicPeriod)
                .Include(a => a.AssessmentType)
                .Include(a => a.School)
                .Include(a => a.AcademicAssessmentDetails)
                    .ThenInclude(a => a.Student)
                .Include(a => a.Subject)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (academicAssessment == null)
            {
                return NotFound();
            }

            return View(academicAssessment);
        }

        // GET: AcademicAssessments/Create
        public async Task<IActionResult> Create()
        {

            ViewData["subjects"] = await _context.Subjects.ToListAsync();
            ViewData["schools"] = await _context.Schools.ToListAsync();
            ViewData["students"] = await _context.Students.ToListAsync();
            ViewData["AcademicPeriod"] = await _context.AcademicPeriods.ToListAsync();
            ViewData["AssessmentType"] = await _context.AcademicAssessmentTypes.ToListAsync();
            
            return View();
        }

        // POST: AcademicAssessments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Weight,MaximumScore,SchoolId,SubjectId,AssessmentDate,AcademicPeriodId,AssessmentTypeId")] AcademicAssessment academicAssessment, int[] studentId, int[] score)
        {

            AcademicAssessment a = new AcademicAssessment
            {
                AssessmentDate = DateTime.Now,
                Weight = academicAssessment.Weight,
                SubjectId = academicAssessment.SubjectId,
                SchoolId = academicAssessment.SchoolId,
                AcademicPeriodId = academicAssessment.AcademicPeriodId,
                AssessmentTypeId = academicAssessment.AssessmentTypeId,
                MaximumScore = academicAssessment.MaximumScore
            };

            int counter = 0;
            a.AcademicAssessmentDetails = new List<AcademicAssessmentDetails>();
            foreach (var student in studentId)
            {
                a.AcademicAssessmentDetails.Add(new AcademicAssessmentDetails
                {
                    StudentId = student,
                    Score = score[counter]
                });
                counter++;
            }


            _context.Add(a);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // GET: AcademicAssessments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicAssessment = await _context.AcademicAssessments.FindAsync(id);
            if (academicAssessment == null)
            {
                return NotFound();
            }
            ViewData["AcademicPeriodId"] = new SelectList(_context.Set<AcademicPeriod>(), "Id", "Id", academicAssessment.AcademicPeriodId);
            ViewData["AssessmentTypeId"] = new SelectList(_context.AcademicAssessmentTypes, "ID", "ID", academicAssessment.AssessmentTypeId);
            ViewData["SchoolId"] = new SelectList(_context.Schools, "ID", "ID", academicAssessment.SchoolId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Id", academicAssessment.SubjectId);
            return View(academicAssessment);
        }

        // POST: AcademicAssessments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Score,Weight,SchoolId,StudentId,SubjectId,AssessmentDate,AcademicPeriodId,AssessmentTypeId")] AcademicAssessment academicAssessment)
        {
            if (id != academicAssessment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academicAssessment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcademicAssessmentExists(academicAssessment.ID))
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
            ViewData["AcademicPeriodId"] = new SelectList(_context.Set<AcademicPeriod>(), "Id", "Id", academicAssessment.AcademicPeriodId);
            ViewData["AssessmentTypeId"] = new SelectList(_context.AcademicAssessmentTypes, "ID", "ID", academicAssessment.AssessmentTypeId);
            ViewData["SchoolId"] = new SelectList(_context.Schools, "ID", "ID", academicAssessment.SchoolId);
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "Id", "Id", academicAssessment.SubjectId);
            return View(academicAssessment);
        }

        private bool AcademicAssessmentExists(int id)
        {
            return _context.AcademicAssessments.Any(e => e.ID == id);
        }
    }
}
