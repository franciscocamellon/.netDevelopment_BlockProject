using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Services;

namespace SocialNetwork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppApiController : ControllerBase
    {
        private readonly IAppServices _appServices;

        public AppApiController(IAppServices appServices)
        {
            _appServices = appServices;
        }

        // GET: api/AppApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppModel>>> Get(string search)
        {
            var appModel = await _appServices.GetAllAsync(search);

            return Ok(appModel);
        }

        // GET: api/AppApi/5
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AppModel>> Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var appModel = await _appServices.GetByIdAsync(id);

            if (appModel == null)
            {
                return NotFound();
            }

            return Ok(appModel);
        }

        // PUT: api/AppApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] AppModel appModel)
        {
            if (id != appModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(appModel);
            }
            
            try
            {
                var editedAppModel = await _appServices.EditAsync(appModel);

                return Ok(editedAppModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(409);
            }
            return Ok();
        }

        // POST: api/AppApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppModel>> Post([FromBody] AppModel appModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(appModel);
            }
            
            var albumCreated = await _appServices.CreateAsync(appModel);

            return Ok(albumCreated);
        }

        // DELETE: api/AppApi/5
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            await _appServices.DeleteAsync(id);

            return Ok();
        }

        [HttpGet("IsUnusedName/{appName}/{id:guid}")]
        public async Task<IActionResult> IsUnusedName(string appName, Guid id)
        {
            var isUsed = await _appServices.IsUnusedNameAsync(appName, id);

            return Ok(isUsed);
        }
    }
}
