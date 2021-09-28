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
        Task<IEnumerable<PictureModel>> GetPicturesByAlbumIdAsync(Guid albumId);
        Task<IEnumerable<PictureModel>> GetAllAsync();
        Task<PictureModel> GetByIdAsync(Guid id);
        Task<PictureModel> CreateAsync(PictureModel picture);
        Task DeleteAsync(Guid id);
    }
}
