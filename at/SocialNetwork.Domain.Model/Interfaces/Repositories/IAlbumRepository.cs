using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Model.Entities;

namespace SocialNetwork.Domain.Model.Interfaces.Repositories
{
    public interface IAlbumRepository
    {
        Task<IEnumerable<AlbumModel>> GetAlbumsByProfileIdAsync(int profileId);
        Task<IEnumerable<AlbumModel>> GetAllAsync(string search);
        Task<AlbumModel> GetByIdAsync(Guid id);
        Task<AlbumModel> CreateAsync(AlbumModel album);
        Task<AlbumModel> EditAsync(AlbumModel album);
        Task DeleteAsync(Guid id);
        Task<AlbumModel> GetNameNotFromThisIdAsync(string albumName, Guid id);
    }
}
