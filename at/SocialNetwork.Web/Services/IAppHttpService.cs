using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Services
{
    public interface IAppHttpService
    {
        Task<IEnumerable<AppViewModel>> GetAppsByProfileIdAsync(int profileId);
        Task<IEnumerable<AppViewModel>> GetAllAsync(string search);
        Task<AppViewModel> GetByIdAsync(Guid id);
        Task<AppViewModel> CreateAsync(AppViewModel appModel);
        Task<AppViewModel> EditAsync(AppViewModel appModel);
        Task DeleteAsync(Guid id);
        Task<bool> IsUnusedNameAsync(string appName, Guid id);
    }
}
