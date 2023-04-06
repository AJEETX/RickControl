using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Data.Context;
using app.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    public class ClaimCaseController : Controller
    {
        private readonly RiskControlDbContext _context;

        public ClaimCaseController(RiskControlDbContext context)
        {
            _context = context;
        }

        // GET: ClaimCase
        public async Task<IActionResult> Index()
        {
            return View(await _context.Case.ToListAsync());
        }

        // GET: ClaimCase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claimCase = await _context.Case
                .FirstOrDefaultAsync(m => m.Id == id);
            if (claimCase == null)
            {
                return NotFound();
            }

            return View(claimCase);
        }

        // GET: ClaimCase/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClaimCase/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,KYCCaseStatus,Description,Active,Id,CreateDate")] ClaimCase claimCase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claimCase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(claimCase);
        }

        // GET: ClaimCase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claimCase = await _context.Case.FindAsync(id);
            if (claimCase == null)
            {
                return NotFound();
            }
            return View(claimCase);
        }

        // POST: ClaimCase/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,KYCCaseStatus,Description,Active,Id,CreateDate")] ClaimCase claimCase)
        {
            if (id != claimCase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(claimCase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaimCaseExists(claimCase.Id))
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
            return View(claimCase);
        }

        // GET: ClaimCase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claimCase = await _context.Case
                .FirstOrDefaultAsync(m => m.Id == id);
            if (claimCase == null)
            {
                return NotFound();
            }

            return View(claimCase);
        }

        // POST: ClaimCase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var claimCase = await _context.Case.FindAsync(id);
            _context.Case.Remove(claimCase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClaimCaseExists(int id)
        {
            return _context.Case.Any(e => e.Id == id);
        }
    }
}
