using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using travis_resume.Data;
using travis_resume.Models;

namespace travis_resume.Controllers
{
    public class EducationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EducationController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Education
        public async Task<IActionResult> Index()
        {
            return View(await _context.Education.ToListAsync());
        }

        // GET: Education/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var education = await _context.Education.SingleOrDefaultAsync(m => m.EducationId == id);
            if (education == null)
            {
                return NotFound();
            }

            return View(education);
        }

        // GET: Education/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Education/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EducationId,AddressCity,AddressId,AddressLineOne,AddressLineTwo,AddressState,AddressZip,EducationDescription,EducationLevel,EducationName")] Education education)
        {
            if (ModelState.IsValid)
            {
                _context.Add(education);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(education);
        }

        // GET: Education/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var education = await _context.Education.SingleOrDefaultAsync(m => m.EducationId == id);
            if (education == null)
            {
                return NotFound();
            }
            return View(education);
        }

        // POST: Education/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EducationId,AddressCity,AddressId,AddressLineOne,AddressLineTwo,AddressState,AddressZip,EducationDescription,EducationLevel,EducationName")] Education education)
        {
            if (id != education.EducationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(education);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EducationExists(education.EducationId))
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
            return View(education);
        }

        // GET: Education/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var education = await _context.Education.SingleOrDefaultAsync(m => m.EducationId == id);
            if (education == null)
            {
                return NotFound();
            }

            return View(education);
        }

        // POST: Education/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var education = await _context.Education.SingleOrDefaultAsync(m => m.EducationId == id);
            _context.Education.Remove(education);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EducationExists(int id)
        {
            return _context.Education.Any(e => e.EducationId == id);
        }
    }
}
