﻿using System;
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
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Web.Models;
using SocialNetwork.Web.Services;

namespace SocialNetwork.Web.Controllers
{
    public class PicturesController : Controller
    {
        private readonly IAlbumHttpService _albumHttpService;
        private readonly IPictureHttpService _pictureHttpService;

        public PicturesController(IAlbumHttpService albumHttpService,
                                  IPictureHttpService pictureHttpService)
        {
            _albumHttpService = albumHttpService;
            _pictureHttpService = pictureHttpService;
        }

        // GET: Pictures
        public async Task<IActionResult> Index(PictureIndexViewModel pictureIndexRequest)
        {
            var pictureIndexViewModel = new PictureIndexViewModel
            {
                OrderAscendant = pictureIndexRequest.OrderAscendant,
                Pictures = await _pictureHttpService.GetAllAsync(pictureIndexRequest.OrderAscendant)
            };

            return View(pictureIndexViewModel);
        }

        // GET: Pictures/Details/5 --> deletar
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pictureViewModel = await _pictureHttpService.GetByIdAsync(id.Value);

            if (pictureViewModel == null)
            {
                return NotFound();
            }

            return View(pictureViewModel);
        }

        // GET: Pictures/Create
        public async Task<IActionResult> Create(Guid id)
        {
            await FillWithAlbumId(string.Empty , id);

            return View();
        }

        // POST: Pictures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection form,
                                                [FromServices] IHttpClientFactory clientFactory,
                                                [Bind("Id,UploadDate,UriImageAlbum,AlbumId")] PictureViewModel pictureViewModel)
        {
            var imageUriList = await GetImageUriFromApi(form, clientFactory);

            foreach (var imageUri in imageUriList)
            {
                pictureViewModel.Id = Guid.NewGuid();
                pictureViewModel.UploadDate = DateTime.Now;
                pictureViewModel.UriImageAlbum = imageUri;

                await  _pictureHttpService.CreateAsync(pictureViewModel);
            }
            
            return RedirectToAction(nameof(Index), "Albums");
            
        }

        // GET: Pictures/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pictureViewModel = await _pictureHttpService.GetByIdAsync(id.Value);

            if (pictureViewModel == null)
            {
                return NotFound();
            }

            return View(pictureViewModel);
        }

        // POST: UserPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _pictureHttpService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
        
        private async Task<IEnumerable<string>> GetImageUriFromApi(IFormCollection form,
                                                                   [FromServices] IHttpClientFactory clientFactory)
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
                var uriImage = JsonConvert.DeserializeObject<string[]>(responseResult);

                return uriImage;
            }
        }

        private static StreamContent CreateFileContent(Stream stream, string fileName, string contentType)
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

        private async Task FillWithAlbumId(string search, Guid? albumId = null)
        {
            var albumViewModels = await _albumHttpService.GetAllAsync(search);

            ViewBag.Albuns = new SelectList(
                albumViewModels,
                nameof(AlbumModel.Id),
                nameof(AlbumModel.AlbumName),
                albumId);
        }
    }
}
