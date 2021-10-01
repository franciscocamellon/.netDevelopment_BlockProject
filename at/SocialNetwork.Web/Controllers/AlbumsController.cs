using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Web.Models;
using SocialNetwork.Web.Services;

namespace SocialNetwork.Web.Controllers
{
    [Authorize]
    public class AlbumsController : Controller
    {
        private readonly IAlbumHttpService _albumHttpService;
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;

        public AlbumsController(IAlbumHttpService albumHttpService,
                                UserManager<User> userManager,
                                IProfileRepository profileRepository)
        {
            _albumHttpService = albumHttpService;
            _userManager = userManager;
            _profileRepository = profileRepository;
        }

        // GET: Albums
        public async Task<IActionResult> Index(AlbumIndexViewModel albumIndexRequest)
        {
            var albumIndexViewModel = new AlbumIndexViewModel
            {
                Search = string.Empty,
                Albums = await _albumHttpService.GetAllAsync(albumIndexRequest.Search)
            };

            return View(albumIndexViewModel);
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var albumViewModel = await _albumHttpService.GetByIdAsync(id.Value);

            if (albumViewModel == null)
            {
                return NotFound();
            }

            return View(albumViewModel);
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
        public async Task<IActionResult> Create([Bind("Id,CreationDate,AlbumName,ProfileId")] AlbumViewModel albumViewModel)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = _userManager.GetUserId(User);
                var profile = await _profileRepository.GetProfileByUserIdAsync(currentUserId);

                albumViewModel.ProfileId = profile.Id;
                albumViewModel.Id = Guid.NewGuid();
                albumViewModel.CreationDate = DateTime.Now;

                await _albumHttpService.CreateAsync(albumViewModel);

                return RedirectToAction(nameof(Create), "Pictures",new {id = albumViewModel.Id});
            }
           
            return View(albumViewModel);
        }

        // GET: Albums
        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var albumViewModel = await _albumHttpService.GetByIdAsync(id.Value);
            
            if (albumViewModel == null)
            {
                return NotFound();
            }

            return View(albumViewModel);
        }

        // POST: Developer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AlbumViewModel albumViewModel)
        {
            if (id != albumViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(albumViewModel);
            }
            
            try
            {
                await _albumHttpService.EditAsync(albumViewModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                var exists = await AlbumModelExistsAsync(albumViewModel.Id);

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

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chosenAlbum = await _albumHttpService.GetByIdAsync(id.Value);

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
            await _albumHttpService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AlbumModelExistsAsync(Guid id)
        {
            var developer = await _albumHttpService.GetByIdAsync(id);

            var any = developer != null;

            return any;
        }
    }
}
