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
    public class AlbumRepository : IAlbumRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AlbumRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Album>> GetAlbumsByProfileIdAsync(int profileId)
        {
            var albums = _dbContext.Albums.Where(x => x.ProfileId == profileId);
            return await albums.ToListAsync();
        }

        public async Task<IEnumerable<Album>> GetAllAsync()
        {
            var albums = _dbContext.Albums.OrderBy(x => x.CreationDate);

            return await albums.ToListAsync();
        }
        public async Task<Album> GetByIdAsync(Guid id)
        {
            var album = await _dbContext.Albums.FirstOrDefaultAsync(x => x.Id == id);

            return album;
        }
        public async Task<Album> CreateAsync(Album album)
        {
            var createdAlbum = _dbContext.Albums.Add(album);
            await _dbContext.SaveChangesAsync();

            return createdAlbum.Entity;
        }
        public async Task<Album> EditAsync(Album album)
        {
            var updatedAlbum = _dbContext.Albums.Update(album);
            await _dbContext.SaveChangesAsync();

            return updatedAlbum.Entity;
        }
        public async Task DeleteAsync(Guid id)
        {
            var album = await GetByIdAsync(id);

            _dbContext.Albums.Remove(album);

            await _dbContext.SaveChangesAsync();
        }
    }
}
