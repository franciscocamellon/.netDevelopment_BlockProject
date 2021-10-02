using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;

namespace SocialNetwork.Data.Repositories
{
    public class PictureRepository : IPictureRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PictureRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<PictureModel>> GetPicturesByAlbumIdAsync(Guid albumId)
        {
            var pictures = await _dbContext.Pictures
                .Where(x => x.AlbumId == albumId)
                .ToListAsync();

            return pictures;
        }

        public async Task<IEnumerable<PictureModel>> GetAllAsync(bool orderAscendant = true)
        {
            var pictures = orderAscendant
                ? _dbContext.Pictures.OrderBy(x => x.UploadDate)
                : _dbContext.Pictures.OrderByDescending(x => x.UploadDate);

            return await pictures 
                .Include(x => x.Album)
                .ToListAsync();
        }

        public async Task<PictureModel> GetByIdAsync(Guid id)
        {
            var picture = await _dbContext.Pictures
                .Include(x => x.Album)
                .FirstOrDefaultAsync(x => x.Id == id);

            return picture;
        }

        public async Task<PictureModel> CreateAsync(PictureModel pictureModel)
        {
            var createdPicture = _dbContext.Pictures.Add(pictureModel);

            await _dbContext.SaveChangesAsync();

            return createdPicture.Entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            var picture = await GetByIdAsync(id);

            _dbContext.Pictures.Remove(picture);

            await _dbContext.SaveChangesAsync();
        }
    }
}
