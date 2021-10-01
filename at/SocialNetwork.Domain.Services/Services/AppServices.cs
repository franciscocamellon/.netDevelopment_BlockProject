using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Domain.Model.Interfaces.Services;

namespace SocialNetwork.Domain.Services.Services
{
    public class AppServices : IAppServices
    {
        private readonly IAppsRepository _appsRepository;

        public AppServices(IAppsRepository appsRepository)
        {
            _appsRepository = appsRepository;
        }
        public async Task<IEnumerable<AppModel>> GetAppsByProfileIdAsync(int profileId)
        {
            return await _appsRepository.GetAppsByProfileIdAsync(profileId);
        }

        public async Task<IEnumerable<AppModel>> GetAllAsync(string search=null)
        {
            return await _appsRepository.GetAllAsync(search);
        }

        public async Task<AppModel> GetByIdAsync(Guid id)
        {
            return await _appsRepository.GetByIdAsync(id);
        }

        public async Task<AppModel> CreateAsync(AppModel appModel)
        {
            return await _appsRepository.CreateAsync(appModel);
        }

        public async Task<AppModel> EditAsync(AppModel appModel)
        {
            return await _appsRepository.EditAsync(appModel);
        }
       
        public async Task DeleteAsync(Guid id)
        {
            await _appsRepository.DeleteAsync(id);
        }

        public async Task<bool> IsUnusedNameAsync(string appName, Guid id)
        {
            var appModel = await _appsRepository.GetNameNotFromThisIdAsync(appName, id);

            return appModel == null;
        }
    }
}
