using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Services
{
    public interface IAlbumHttpService
    {
        Task<IEnumerable<AlbumViewModel>> GetAlbumsByProfileIdAsync(int profileId);
        Task<IEnumerable<AlbumViewModel>> GetAllAsync(string search);
        Task<AlbumViewModel> GetByIdAsync(Guid id);
        Task<AlbumViewModel> CreateAsync(AlbumViewModel album);
        Task<AlbumViewModel> EditAsync(AlbumViewModel album);
        Task DeleteAsync(Guid id);
    }
}
