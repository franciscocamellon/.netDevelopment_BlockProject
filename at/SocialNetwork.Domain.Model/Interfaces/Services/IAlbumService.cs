using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Model.Entities;

namespace SocialNetwork.Domain.Model.Interfaces.Services
{
    public interface IAlbumService
    {
        Task<IEnumerable<AlbumModel>> GetAlbumsByProfileIdAsync(int profileId);
        Task<IEnumerable<AlbumModel>> GetAllAsync(string search);
        Task<AlbumModel> GetByIdAsync(Guid id);
        Task<AlbumModel> CreateAsync(AlbumModel album);
        Task<AlbumModel> EditAsync(AlbumModel album);
        Task DeleteAsync(Guid id);
        Task<bool> IsUnusedNameAsync(string albumName, Guid id);
    }
}
