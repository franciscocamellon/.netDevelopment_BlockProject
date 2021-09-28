using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SocialNetwork.Data;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Interfaces.Repositories;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly IPictureRepository _pictureRepository;

        public AlbumsController(ApplicationDbContext context,
                                UserManager<User> userManager,
                                IProfileRepository profileRepository,
                                IAlbumRepository albumRepository,
                                IPictureRepository pictureRepository)
        {
            _context = context;
            _userManager = userManager;
            _profileRepository = profileRepository;
            _albumRepository = albumRepository;
            _pictureRepository = pictureRepository;
        }

        // GET: Albums
        public async Task<IActionResult> Index()
        {
            var albumIndexViewModel = new AlbumIndexViewModel
            {
                Albums = await _albumRepository.GetAllAsync()
            };

            return View(albumIndexViewModel);
        }

        // GET: Albums
        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var album = await _albumRepository.GetByIdAsync(id.Value);
            
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: Developer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AlbumModel albumModel)
        {
            if (id != albumModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(albumModel);
            }
            
            try
            {
                await _albumRepository.EditAsync(albumModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                var exists = await AlbumModelExistsAsync(albumModel.Id);

                if (!exists)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Details), "Albums", new { id });
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreationDate,AlbumName,ProfileId")] AlbumModel album)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = _userManager.GetUserId(User);
                var profile = await _profileRepository.GetProfileByUserIdAsync(currentUserId);

                album.ProfileId = profile.Id;
                album.Id = Guid.NewGuid();
                album.CreationDate = DateTime.Now;

                await _albumRepository.CreateAsync(album);

                return RedirectToAction(nameof(Create), "Pictures", new {AlbumId = album.Id});
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

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var album = await _context.Albums
                .Include(u => u.Pictures)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        private async Task<bool> AlbumModelExistsAsync(Guid id)
        {
            var developer = await _albumRepository.GetByIdAsync(id);

            var any = developer != null;

            return any;
        }
    }
}
