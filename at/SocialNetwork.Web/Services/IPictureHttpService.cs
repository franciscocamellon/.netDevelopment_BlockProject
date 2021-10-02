using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Services
{
    public interface IPictureHttpService
    {
        Task<IEnumerable<PictureViewModel>> GetPicturesByAlbumIdAsync(Guid albumId);
        Task<IEnumerable<PictureViewModel>> GetAllAsync(bool orderAscendant);
        Task<PictureViewModel> GetByIdAsync(Guid id);
        Task<PictureViewModel> CreateAsync(PictureViewModel pictureModel);
        Task DeleteAsync(Guid id);
    }
}
