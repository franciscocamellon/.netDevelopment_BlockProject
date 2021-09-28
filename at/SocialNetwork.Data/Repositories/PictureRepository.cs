using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Interfaces.Repositories;

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
            var pictures = _dbContext.Pictures.Where(x => x.AlbumId == albumId);
            return await pictures.ToListAsync();
        }

        public async Task<IEnumerable<PictureModel>> GetAllAsync()
        {
            var pictures = _dbContext.Pictures.OrderBy(x => x.UploadDate);

            return await pictures.ToListAsync();
        }

        public async Task<PictureModel> GetByIdAsync(Guid id)
        {
            var picture = await _dbContext.Pictures.FirstOrDefaultAsync(x => x.Id == id);

            return picture;
        }

        public async Task<PictureModel> CreateAsync(PictureModel picture)
        {
            var createdPicture = _dbContext.Pictures.Add(picture);
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
