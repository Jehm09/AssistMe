﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssistMeProject.Models;

namespace AssistMeProject.Controllers
{
    //
    public class InterestingVController : Controller
    {
        private readonly AssistMeProjectContext _context;

        public InterestingVController(AssistMeProjectContext context)
        {
            _context = context;
        }

        // GET: InterestingV
        public async Task<IActionResult> Index()
        {
            var assistMeProjectContext = _context.InterestingVote.Include(i => i.Question).Include(i => i.User);
            return View(await assistMeProjectContext.ToListAsync());
        }

        // GET: InterestingV/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interestingVote = await _context.InterestingVote
                .Include(i => i.Question)
                .Include(i => i.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (interestingVote == null)
            {
                return NotFound();
            }

            return View(interestingVote);
        }
        

        // POST: InterestingV/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        public async Task<int> Create([Bind("ID,UserID,QuestionID")] InterestingVote interestingVote)
        {
            if (ModelState.IsValid)
            {
                var lista = _context.InterestingVote.Where(x => x.UserID == interestingVote.UserID &&x.QuestionID==interestingVote.QuestionID).ToList();
                if (lista.Count()>0)
                {
                    _context.InterestingVote.Remove(lista.First());
                    await _context.SaveChangesAsync();
                    return -1;
                }
                else {
                     _context.Add(interestingVote);
                    await _context.SaveChangesAsync();
                    return 1;
                }
            }
            return 0;
        }

        // GET: InterestingV/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interestingVote = await _context.InterestingVote.FindAsync(id);
            if (interestingVote == null)
            {
                return NotFound();
            }
            ViewData["QuestionID"] = new SelectList(_context.Question, "Id", "Description", interestingVote.QuestionID);
            ViewData["UserID"] = new SelectList(_context.User, "ID", "ID", interestingVote.UserID);
            return View(interestingVote);
        }

        // POST: InterestingV/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,QuestionID")] InterestingVote interestingVote)
        {
            if (id != interestingVote.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interestingVote);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterestingVoteExists(interestingVote.ID))
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
            ViewData["QuestionID"] = new SelectList(_context.Question, "Id", "Description", interestingVote.QuestionID);
            ViewData["UserID"] = new SelectList(_context.User, "ID", "ID", interestingVote.UserID);
            return View(interestingVote);
        }

        // GET: InterestingV/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interestingVote = await _context.InterestingVote
                .Include(i => i.Question)
                .Include(i => i.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (interestingVote == null)
            {
                return NotFound();
            }

            return View(interestingVote);
        }

        // POST: InterestingV/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interestingVote = await _context.InterestingVote.FindAsync(id);
            _context.InterestingVote.Remove(interestingVote);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterestingVoteExists(int id)
        {
            return _context.InterestingVote.Any(e => e.ID == id);
        }
    }
}
