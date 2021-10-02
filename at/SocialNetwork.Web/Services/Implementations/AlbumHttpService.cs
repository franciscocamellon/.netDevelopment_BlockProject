using SocialNetwork.Web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Services.Implementations
{
    public class AlbumHttpService : IAlbumHttpService
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            IgnoreNullValues = true,
            PropertyNameCaseInsensitive = true
        };

        public AlbumHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<AlbumViewModel>> GetAlbumsByProfileIdAsync(int profileId)
        {
            var album = await _httpClient
                .GetFromJsonAsync<IEnumerable<AlbumViewModel>>($"{profileId}");

            return album;
        }

        public async Task<IEnumerable<AlbumViewModel>> GetAllAsync(string search)
        {
            var album = await _httpClient
                .GetFromJsonAsync<IEnumerable<AlbumViewModel>>($"{search}");

            return album;
        }

        public async Task<AlbumViewModel> GetByIdAsync(Guid id)
        {
            var album = await _httpClient
                .GetFromJsonAsync<AlbumViewModel>($"{id}");

            return album;
        }
        public async Task<AlbumViewModel> CreateAsync(AlbumViewModel albumViewModel)
        {
            var httpResponseMessage = await _httpClient
                .PostAsJsonAsync(string.Empty, albumViewModel);

            httpResponseMessage.EnsureSuccessStatusCode();

            await using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            var createdAlbum = await JsonSerializer
                .DeserializeAsync<AlbumViewModel>(contentStream, JsonSerializerOptions);

            return createdAlbum;
        }
        public async Task<AlbumViewModel> EditAsync(AlbumViewModel albumViewModel)
        {
            var httpResponseMessage = await _httpClient
                .PutAsJsonAsync($"{albumViewModel.Id}", albumViewModel);

            httpResponseMessage.EnsureSuccessStatusCode();

            await using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            var editedAlbum = await JsonSerializer
                .DeserializeAsync<AlbumViewModel>(contentStream, JsonSerializerOptions);

            return editedAlbum;
        }

        public async Task DeleteAsync(Guid id)
        {
            var httpResponseMessage = await _httpClient
                .DeleteAsync($"{id}");

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        

        
    }
}
