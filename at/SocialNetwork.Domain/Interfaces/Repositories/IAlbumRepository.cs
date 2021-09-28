using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Interfaces.Repositories
{
    public interface IAlbumRepository
    {
        Task<IEnumerable<AlbumModel>> GetAlbumsByProfileIdAsync(int profileId);
        Task<IEnumerable<AlbumModel>> GetAllAsync();
        Task<AlbumModel> GetByIdAsync(Guid id);
        Task<AlbumModel> CreateAsync(AlbumModel album);
        Task<AlbumModel> EditAsync(AlbumModel album);
        Task DeleteAsync(Guid id);
    }
}
