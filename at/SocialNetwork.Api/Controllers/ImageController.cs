using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Domain.Model.Interfaces.Infrastructure;

namespace SocialNetwork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IEnumerable<string>> Upload([FromServices] IBlobService blobService)
        {
            //valida content do request
            if (!Request.HasFormContentType)
                BadRequest();

            //inicia upload (assincronamente)
            var tasks = Request.Form.Files.Select(file =>
            {
                return blobService.UploadAsync(file.OpenReadStream());
            });

            //aguarda todas as tasks e devolve lista de uris
            return await Task.WhenAll(tasks);
        }
    }
}
