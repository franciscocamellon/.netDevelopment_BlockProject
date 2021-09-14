using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Interfaces.Repositories;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IProfileRepository _profileRepository;

        public ProfileController(UserManager<User> userManager,
                                 IProfileRepository profileRepository)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
         }

        //action para exibição da view
        public async Task<IActionResult> Edit()
        {
            //recuperando user completo do banco de dados
            var currentUserId = _userManager.GetUserId(User);

            //obter a entidade perfil
            var profile = await _profileRepository.GetProfileByUserIdAsync(currentUserId);

            return View(profile);
        }

        //action para atualização dos dados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] Profile profileForm)
        {
            //recuperando user completo do banco de dados
            var currentUserId = _userManager.GetUserId(User);

            //obter a entidade perfil
            var profileFromBd = await _profileRepository.GetProfileByUserIdAsync(currentUserId);
            
            //atribuindo o id do user (identity) ao profile
            profileForm.UserId = currentUserId;

            //validando se usuário existe em banco, e se existir, valida id do formulário com id do banco
            if (profileFromBd == null)
            {
                await _profileRepository.InsertAsync(profileForm);
                return RedirectToAction(nameof(Edit));
            }
            else
            {
                if (profileFromBd.Id != profileForm.Id)
                    throw new ApplicationException("UserId is different from database");

                //mantendo integro a imagem de profile (se existir)
                profileForm.UriImageProfile = profileFromBd.UriImageProfile;

                //atualizando no banco de dados
                await _profileRepository.UpdateAsync(profileForm);
            }

            ViewBag.ShowMessage = true;
            return View(profileForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditImageProfile(IFormCollection form,
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
                var uriImage = JsonConvert.DeserializeObject<string[]>(responseResult).FirstOrDefault();

                //recuperando user completo do banco de dados
                var currentUserId = _userManager.GetUserId(User);

                //obter a entidade perfil do banco
                var profileFromBd = await _profileRepository.GetProfileByUserIdAsync(currentUserId);
                if (profileFromBd == null)
                {
                    var profileToInsert = new Profile();
                    profileToInsert.UserId = currentUserId;
                    profileToInsert.UriImageProfile = uriImage;
                    await _profileRepository.InsertAsync(profileToInsert);
                }
                else
                {
                    profileFromBd.UriImageProfile = uriImage;
                    await _profileRepository.UpdateAsync(profileFromBd);
                }
            }

            return RedirectToAction(nameof(Edit));
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
