using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Interfaces.Repositories;

namespace SocialNetwork.Web.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;
        private readonly IAlbumRepository _albumRepository;

        public AlbumsController(ApplicationDbContext context,
                                UserManager<User> userManager,
                                IProfileRepository profileRepository,
                                IAlbumRepository albumRepository)
        {
            _context = context;
            _userManager = userManager;
            _profileRepository = profileRepository;
            _albumRepository = albumRepository;
        }

        // GET: Albums
        public async Task<IActionResult> Index()
        {
            var currentUserId = _userManager.GetUserId(User);
            var profile = await _profileRepository.GetProfileByUserIdAsync(currentUserId);
            

            var albumsByProfile = await _albumRepository.GetAlbumsByProfileIdAsync(profile.Id);
            //var albumsByProfile = profile.Albums;

            return View(albumsByProfile);
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chosenAlbum = await _albumRepository.GetByIdAsync(id.Value);
            
            if (chosenAlbum == null)
            {
                return NotFound();
            }

            return View(chosenAlbum);
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreationDate,AlbumName,ProfileId")] Album album)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = _userManager.GetUserId(User);
                var profile = await _profileRepository.GetProfileByUserIdAsync(currentUserId);

                album.ProfileId = profile.Id;
                album.Id = Guid.NewGuid();

                await _albumRepository.CreateAsync(album);

                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }

        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chosenAlbum = await _albumRepository.GetByIdAsync(id.Value);
            if (chosenAlbum == null)
            {
                return NotFound();
            }
            return View(chosenAlbum);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CreationDate,AlbumName,ProfileId")] Album album)
        {
            if (id != album.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _albumRepository.EditAsync(album);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var albumExist = await AlbumExists(album.Id);
                    if (albumExist)
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
            return View(album);
        }

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chosenAlbum = await _albumRepository.GetByIdAsync(id.Value);

            if (chosenAlbum == null)
            {
                return NotFound();
            }

            return View(chosenAlbum);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _albumRepository.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AlbumExists(Guid id)
        {
            var album = await _albumRepository.GetByIdAsync(id);

            var any = album != null;

            return any;
        }
    }
}
