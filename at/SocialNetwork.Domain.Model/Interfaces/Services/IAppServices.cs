using SocialNetwork.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Interfaces.Services
{
    public interface IAppServices
    {
        Task<IEnumerable<AppModel>> GetAppsByProfileIdAsync(int profileId);
        Task<IEnumerable<AppModel>> GetAllAsync(string search);
        Task<AppModel> GetByIdAsync(Guid id);
        Task<AppModel> CreateAsync(AppModel appModel);
        Task<AppModel> EditAsync(AppModel appModel);
        Task DeleteAsync(Guid id);
        Task<bool> IsUnusedNameAsync(string appName, Guid id);
    }
}
