using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Services;

namespace SocialNetwork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumApiController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumApiController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        // GET: api/AlbumApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlbumModel>>> Get(string search)
        {
            var albumModel = await _albumService.GetAllAsync(search);

            return Ok(albumModel);
        }

        // GET: api/AlbumApi/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AlbumModel>> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var albumModel = await _albumService.GetByIdAsync(id);

            if (albumModel == null)
            {
                return NotFound();
            }

            return Ok(albumModel);
        }

        // POST: api/AlbumApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlbumModel>> Post([FromBody] AlbumModel albumModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(albumModel);
            }
            
            var albumCreated = await _albumService.CreateAsync(albumModel);

            return Ok(albumCreated);
        }

        // PUT: api/AlbumApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<AlbumModel>> Put(Guid id, [FromBody] AlbumModel albumModel)
        {
            if (id != albumModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(albumModel);
            }
            
            try
            {
                var editedAlbumModel = await _albumService.EditAsync(albumModel);

                return Ok(editedAlbumModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(409);
            }
            return Ok();
        }

        // DELETE: api/AlbumApi/5
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            await _albumService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet("IsUnusedName/{albumName}/{id:guid}")]
        public async Task<IActionResult> IsUnusedName(string albumName, Guid id)
        {
            var isUsed = await _albumService.IsUnusedNameAsync(albumName, id);

            return Ok(isUsed);
        }
    }
}
