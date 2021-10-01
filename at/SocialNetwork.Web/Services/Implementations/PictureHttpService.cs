using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Services.Implementations
{
    public class PictureHttpService : IPictureHttpService
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            IgnoreNullValues = true,
            PropertyNameCaseInsensitive = true
        };

        public PictureHttpService(HttpClient _httpClient)
        {
            this._httpClient = _httpClient;
        }
        public async Task<IEnumerable<PictureViewModel>> GetPicturesByAlbumIdAsync(Guid albumId)
        {
            var picture = await _httpClient
                .GetFromJsonAsync<IEnumerable<PictureViewModel>>($"{albumId}");

            return picture;
        }

        public async Task<IEnumerable<PictureViewModel>> GetAllAsync(bool orderAscendant = true)
        {
            var picture = await _httpClient
                .GetFromJsonAsync<IEnumerable<PictureViewModel>>($"{orderAscendant}");

            return picture;
        }

        public async Task<PictureViewModel> GetByIdAsync(Guid id)
        {
            var picture = await _httpClient
                .GetFromJsonAsync<PictureViewModel>($"{id}");

            return picture;
        }

        public async Task<PictureViewModel> CreateAsync(PictureViewModel pictureModel)
        {
            var httpResponseMessage = await _httpClient
                .PostAsJsonAsync(string.Empty, pictureModel);

            httpResponseMessage.EnsureSuccessStatusCode();

            await using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            var createdPicture = await JsonSerializer
                .DeserializeAsync<PictureViewModel>(contentStream, JsonSerializerOptions);

            return createdPicture;
        }

        public async Task DeleteAsync(Guid id)
        {
            var httpResponseMessage = await _httpClient
                .DeleteAsync($"{id}");

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
