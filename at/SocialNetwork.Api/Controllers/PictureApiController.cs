using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Services;

namespace SocialNetwork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureApiController : ControllerBase
    {
        private readonly IPictureService _pictureService;

        public PictureApiController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        // GET: api/PictureApi
        [HttpGet("{orderAscendant:bool}")]
        public async Task<ActionResult<IEnumerable<PictureModel>>> Get(bool orderAscendant)
        {
            var pictureModel =  await _pictureService.GetAllAsync(orderAscendant);

            return Ok(pictureModel);
        }

        // GET: api/PictureApi/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<PictureModel>> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var pictureModel = await _pictureService.GetByIdAsync(id);

            if (pictureModel == null)
            {
                return NotFound();
            }

            return Ok(pictureModel);
        }

        // POST: api/PictureApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PictureModel>> Post([FromBody] PictureModel pictureModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(pictureModel);
            }

            var pictureCreated = await _pictureService.CreateAsync(pictureModel);

            return Ok(pictureCreated);
        }

        // DELETE: api/PictureApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePictureModel(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            await _pictureService.DeleteAsync(id);

            return Ok();
        }
    }
}
