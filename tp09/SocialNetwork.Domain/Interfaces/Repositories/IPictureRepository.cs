using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Interfaces.Repositories
{
    public interface IPictureRepository
    {
        Task<IEnumerable<Picture>> GetPicturesByAlbumIdAsync(Guid albumId);
        Task<IEnumerable<Picture>> GetAllAsync();
        Task<Picture> GetByIdAsync(Guid id);
        Task<Picture> CreateAsync(Picture picture);
        Task DeleteAsync(Guid id);
    }
}