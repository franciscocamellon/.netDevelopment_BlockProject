using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Services.Implementations
{
    public class AppHttpService : IAppHttpService
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            IgnoreNullValues = true,
            PropertyNameCaseInsensitive = true
        };

        public AppHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<AppViewModel>> GetAppsByProfileIdAsync(int profileId)
        {
            var appViewModel = await _httpClient
                .GetFromJsonAsync<IEnumerable<AppViewModel>>($"{profileId}");

            return appViewModel;
        }

        public async Task<IEnumerable<AppViewModel>> GetAllAsync(string search)
        {
            var appViewModels = await _httpClient
                .GetFromJsonAsync<IEnumerable<AppViewModel>>($"{search}");

            return appViewModels;
        }

        public async Task<AppViewModel> GetByIdAsync(Guid id)
        {
            var appViewModel = await _httpClient
                .GetFromJsonAsync<AppViewModel>($"{id}");

            return appViewModel;
        }

        public async Task<AppViewModel> CreateAsync(AppViewModel appViewModel)
        {
            var httpResponseMessage = await _httpClient
                .PostAsJsonAsync(string.Empty, appViewModel);

            httpResponseMessage.EnsureSuccessStatusCode();

            await using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            var createdApp = await JsonSerializer
                .DeserializeAsync<AppViewModel>(contentStream, JsonSerializerOptions);

            return createdApp;
        }

        public async Task<AppViewModel> EditAsync(AppViewModel appViewModel)
        {
            var httpResponseMessage = await _httpClient
                .PutAsJsonAsync($"{appViewModel.Id}", appViewModel);

            httpResponseMessage.EnsureSuccessStatusCode();

            await using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            var editedApp = await JsonSerializer
                .DeserializeAsync<AppViewModel>(contentStream, JsonSerializerOptions);

            return editedApp;
        }

        public async Task DeleteAsync(Guid id)
        {
            var httpResponseMessage = await _httpClient
                .DeleteAsync($"{id}");

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task<bool> IsUnusedNameAsync(string appName, Guid id)
        {
            var isUsed = await _httpClient
                .GetFromJsonAsync<bool>($"IsUnusedName/{appName}/{id}");

            return isUsed;
        }
    }
}
