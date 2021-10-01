using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Web.Models;
using SocialNetwork.Web.Services;

namespace SocialNetwork.Web.Controllers
{
    public class AppsController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;
        private readonly IAppHttpService _appHttpService;

        public AppsController(UserManager<User> userManager,
                              IProfileRepository profileRepository,
                              IAppHttpService appHttpService)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
            _appHttpService = appHttpService;
        }

        // GET: Apps
        public async Task<IActionResult> Index(AppIndexViewModel appIndexRequest)
        {
            var appIndexViewModel = new AppIndexViewModel
            {
                Search = string.Empty,
                Apps = await _appHttpService.GetAllAsync(appIndexRequest.Search)
            };

            return View(appIndexViewModel);
        }

        // GET: Apps/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appViewModel = await _appHttpService.GetByIdAsync(id.Value);

            if (appViewModel == null)
            {
                return NotFound();
            }

            return View(appViewModel);
        }

        // GET: Apps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Apps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AppName,Platform,PublishedStatus,PublishedDate,ModificationDate")] AppViewModel appViewModel)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = _userManager.GetUserId(User);
                var profile = await _profileRepository.GetProfileByUserIdAsync(currentUserId);

                appViewModel.ProfileId = profile.Id;
                appViewModel.Id = Guid.NewGuid();

                await _appHttpService.CreateAsync(appViewModel);

                return RedirectToAction(nameof(Index), "Apps");
            }
           
            return View(appViewModel);
        }

        // GET: Apps/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appModel = await _appHttpService.GetByIdAsync(id.Value);

            if (appModel == null)
            {
                return NotFound();
            }
            
            return View(appModel);
        }

        // POST: Apps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,AppName,Platform,PublishedStatus,PublishedDate,ModificationDate,ProfileId")] AppViewModel appViewModel)
        {
            if (id != appViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(appViewModel);
            }
            
            try
            {
                await _appHttpService.EditAsync(appViewModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                var exists = await AppModelExists(appViewModel.Id);

                if (!exists)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Details), "Apps", new { id });
        }

        // GET: Apps/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chosenAppModel = await _appHttpService.GetByIdAsync(id.Value);

            if (chosenAppModel == null)
            {
                return NotFound();
            }

            return View(chosenAppModel);
        }

        // POST: Apps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appHttpService.DeleteAsync(id);
            
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AppModelExists(Guid id)
        {
            var appViewModel = await _appHttpService.GetByIdAsync(id);

            var any = appViewModel != null;

            return any;
        }

        [AcceptVerbs("GET", "POST")]
        public async Task<IActionResult> IsUnusedName(string appName, Guid id)
        {
            return await _appHttpService.IsUnusedNameAsync(appName, id)
            ? Json(true)
            : Json($"O nome {appName} já está sendo usado.");
        }
    }
}
