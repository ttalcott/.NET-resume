using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using travis_resume.Data;
using travis_resume.Models.ResumeViewModels;
using travis_resume.Models;

namespace travis_resume.Controllers
{
    public class ResumeViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResumeViewModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ResumeViewModels
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: ResumeViewModels/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var resume = new ResumeViewModel();
            resume.Contact = await _context.Person.FirstOrDefaultAsync(p => p.PersonId == id);
            resume.Schools = await _context.Education.Where(e => e.PersonId == id).ToListAsync();
            resume.Job = await _context.Jobs.Where(j => j.PersonId == id).ToListAsync();
            return View(resume);

            //ResumeViewModel resumeViewModel = new ResumeViewModel();
            //resumeViewModel.Contact = await _context.Person.SingleOrDefaultAsync(m => m.PersonId == id);
            //resumeViewModel.Job = await _context.Jobs.Where(j => j.PersonId == id)
            //    .AsNoTracking()
            //    .ToListAsync();

            //resumeViewModel.Schools = await _context.Education.Where(e => e.PersonId == id)
            //    .AsNoTracking()
            //    .ToListAsync();

            //if (resumeViewModel == null)
            //{
            //    return NotFound();
            //}

            //return View(resumeViewModel);
        }

        // GET: ResumeViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResumeViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] ResumeViewModel resumeViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resumeViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(resumeViewModel);
        }

        // GET: ResumeViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeViewModel = await _context.ResumeViewModel.SingleOrDefaultAsync(m => m.Id == id);
            if (resumeViewModel == null)
            {
                return NotFound();
            }
            return View(resumeViewModel);
        }

        // POST: ResumeViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] ResumeViewModel resumeViewModel)
        {
            if (id != resumeViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resumeViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeViewModelExists(resumeViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(resumeViewModel);
        }

        // GET: ResumeViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeViewModel = await _context.ResumeViewModel.SingleOrDefaultAsync(m => m.Id == id);
            if (resumeViewModel == null)
            {
                return NotFound();
            }

            return View(resumeViewModel);
        }

        // POST: ResumeViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resumeViewModel = await _context.ResumeViewModel.SingleOrDefaultAsync(m => m.Id == id);
            _context.ResumeViewModel.Remove(resumeViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ResumeViewModelExists(int id)
        {
            return _context.ResumeViewModel.Any(e => e.Id == id);
        }
    }
}
