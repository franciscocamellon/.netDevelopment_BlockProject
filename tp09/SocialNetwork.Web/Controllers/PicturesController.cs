using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data;
using SocialNetwork.Domain.Entities;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using SocialNetwork.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SocialNetwork.Web.Controllers
{
    public class PicturesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;
        private readonly IAlbumRepository _albumRepository;
        private readonly IPictureRepository _pictureRepository;

        public PicturesController(ApplicationDbContext context,
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

        // GET: UserPictures
        public async Task<IActionResult> Index()
        {

            var picture = await _pictureRepository.GetAllAsync();
            
            return View(picture);
        }

        // GET: UserPictures/Details/5 --> deletar
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPicture = await _context.Pictures
                .Include(u => u.Album)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPicture == null)
            {
                return NotFound();
            }

            return View(userPicture);
        }

        // GET: UserPictures/Create
        public IActionResult Create()
        {
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "Id");
            return View();
        }

        // POST: UserPictures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection form,
                                                [FromServices] IHttpClientFactory clientFactory,
                                                [Bind("Id,UploadDate,UriImageAlbum,AlbumId")] Picture picture,
                                                Album album)
        {
           
            using (var content = new MultipartFormDataContent())
            {
                foreach (var file in form.Files)
                {
                    content.Add(CreateFileContent(file.OpenReadStream(), file.FileName, file.ContentType));
                }

                var httpClient = clientFactory.CreateClient();
                var response = await httpClient.PostAsync("api/image", content);

                response.EnsureSuccessStatusCode();
                var responseResult = await response.Content.ReadAsStringAsync();
                var uriImage = JsonConvert.DeserializeObject<string[]>(responseResult).FirstOrDefault();

                //picture.AlbumId = album.Id;
                picture.Id = Guid.NewGuid();
                picture.UriImageAlbum = uriImage;
                picture.UploadDate = DateTime.Now;

                await  _pictureRepository.CreateAsync(picture);

                return RedirectToAction(nameof(Index));
            }
        }

        // GET: UserPictures/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPicture = await _context.Pictures.FindAsync(id);
            if (userPicture == null)
            {
                return NotFound();
            }
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "Id", userPicture.AlbumId);
            return View(userPicture);
        }

        // POST: UserPictures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UploadDate,UriImageAlbum,AlbumId")] Picture userPicture)
        {
            if (id != userPicture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPicture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPictureExists(userPicture.Id))
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
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "Id", userPicture.AlbumId);
            return View(userPicture);
        }

        // GET: UserPictures/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPicture = await _context.Pictures
                .Include(u => u.Album)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPicture == null)
            {
                return NotFound();
            }

            return View(userPicture);
        }

        // POST: UserPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var userPicture = await _context.Pictures.FindAsync(id);
            _context.Pictures.Remove(userPicture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserPictureExists(Guid id)
        {
            return _context.Pictures.Any(e => e.Id == id);
        }

        private StreamContent CreateFileContent(Stream stream, string fileName, string contentType)
        {
            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"files\"",
                FileName = "\"" + fileName + "\""
            };

            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            return fileContent;
        }
    }
}
