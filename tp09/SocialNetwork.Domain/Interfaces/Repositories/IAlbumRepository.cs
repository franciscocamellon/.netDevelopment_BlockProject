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
        Task<IEnumerable<Album>> GetAlbumsByProfileIdAsync(int profileId);
        Task<IEnumerable<Album>> GetAllAsync();
        Task<Album> GetByIdAsync(Guid id);
        Task<Album> CreateAsync(Album album);
        Task<Album> EditAsync(Album album);
        Task DeleteAsync(Guid id);
    }
}
