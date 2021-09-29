using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Model.Interfaces.Repositories
{
    public interface IPictureRepository
    {
        Task<IEnumerable<PictureModel>> GetPicturesByAlbumIdAsync(Guid albumId);
        Task<IEnumerable<PictureModel>> GetAllAsync(bool orderAscendant);
        Task<PictureModel> GetByIdAsync(Guid id);
        Task<PictureModel> CreateAsync(PictureModel pictureModel);
        Task DeleteAsync(Guid id);
    }
}
