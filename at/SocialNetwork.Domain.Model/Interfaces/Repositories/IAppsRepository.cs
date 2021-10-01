using SocialNetwork.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Interfaces.Repositories
{
    public interface IAppsRepository
    {
        Task<IEnumerable<AppModel>> GetAppsByProfileIdAsync(int profileId);
        Task<IEnumerable<AppModel>> GetAllAsync(string search);
        Task<AppModel> GetByIdAsync(Guid id);
        Task<AppModel> CreateAsync(AppModel appModel);
        Task<AppModel> EditAsync(AppModel appModel);
        Task<AppModel> GetNameNotFromThisIdAsync(string appName, Guid id);
        Task DeleteAsync(Guid id);
    }
}
