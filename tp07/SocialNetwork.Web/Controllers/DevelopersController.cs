﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Controllers
{
    public class DevelopersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DevelopersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Developers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Developer.ToListAsync());
        }

        // GET: Developers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var developer = await _context.Developer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (developer == null)
            {
                return NotFound();
            }

            return View(developer);
        }

        // GET: Developers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Developers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,GraduationDate,EmployedStatus,PublishedApps")] Developer developer)
        {
            if (ModelState.IsValid)
            {
                developer.Id = Guid.NewGuid();
                _context.Add(developer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(developer);
        }

        // GET: Developers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var developer = await _context.Developer.FindAsync(id);
            if (developer == null)
            {
                return NotFound();
            }
            return View(developer);
        }

        // POST: Developers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,GraduationDate,EmployedStatus,PublishedApps")] Developer developer)
        {
            if (id != developer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(developer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeveloperExists(developer.Id))
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
            return View(developer);
        }

        // GET: Developers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var developer = await _context.Developer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (developer == null)
            {
                return NotFound();
            }

            return View(developer);
        }

        // POST: Developers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var developer = await _context.Developer.FindAsync(id);
            _context.Developer.Remove(developer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeveloperExists(Guid id)
        {
            return _context.Developer.Any(e => e.Id == id);
        }
    }
}
