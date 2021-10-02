using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;

namespace SocialNetwork.Data.Repositories
{
    public class AppsRepository : IAppsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AppsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<AppModel>> GetAppsByProfileIdAsync(int profileId)
        {
            var appModels = await _dbContext.Apps
                .Where(x => x.ProfileId == profileId)
                .ToListAsync();

            return appModels;
        }

        public async Task<IEnumerable<AppModel>> GetAllAsync(string search=null)
        {
            search ??= string.Empty;
            var appModels = _dbContext.Apps.AsQueryable();

            if (string.IsNullOrWhiteSpace(search))
            {
                appModels = appModels
                    .Where(x=> x.AppName.Contains(search));
            }

            var result = await appModels
                .Select(x => new
                {
                   App = x,
                   ProfileId = x.Profile.Id
                })
                .ToListAsync();

            var appModelResult = result
                .Select(x =>
                {
                    x.App.ProfileId = x.ProfileId;
                    return x.App;
                });

            return appModelResult;
        }

        public async Task<AppModel> GetByIdAsync(Guid id)
        {
            var appModel = await _dbContext.Apps
                .Include(x => x.Profile)
                .FirstOrDefaultAsync(x => x.Id == id);

            return appModel;
        }

        public async Task<AppModel> CreateAsync(AppModel appModel)
        {
            var createdAppModel = _dbContext.Apps.Add(appModel);

            await _dbContext.SaveChangesAsync();

            return createdAppModel.Entity;
        }

        public async Task<AppModel> EditAsync(AppModel appModel)
        {
            var updatedAppModel = _dbContext.Apps.Update(appModel);

            await _dbContext.SaveChangesAsync();

            return updatedAppModel.Entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            var appModel = await GetByIdAsync(id);

            _dbContext.Apps.Remove(appModel);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<AppModel> GetNameNotFromThisIdAsync(string appName, Guid id)
        {
            var appModel = await _dbContext
                .Apps
                .FirstOrDefaultAsync(x => x.AppName == appName && x.Id != id);

            return appModel;
        }
    }
}
