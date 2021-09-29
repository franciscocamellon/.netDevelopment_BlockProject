using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Domain.Model.Interfaces.Services;

namespace SocialNetwork.Domain.Services.Services
{
    public class AlbumServices : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumServices(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public async Task<IEnumerable<AlbumModel>> GetAlbumsByProfileIdAsync(int profileId)
        {
            return await _albumRepository.GetAlbumsByProfileIdAsync(profileId);
        }

        public async Task<IEnumerable<AlbumModel>> GetAllAsync(string search = null)
        {
            return await _albumRepository.GetAllAsync(search);
        }

        public async Task<AlbumModel> GetByIdAsync(Guid id)
        {
            return await _albumRepository.GetByIdAsync(id);
        }

        public async Task<AlbumModel> CreateAsync(AlbumModel albumModel)
        {
            return await _albumRepository.CreateAsync(albumModel);
        }

        public async Task<AlbumModel> EditAsync(AlbumModel albumModel)
        {
            return await _albumRepository.EditAsync(albumModel);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _albumRepository.DeleteAsync(id);
        }

        public async Task<bool> IsUnusedNameAsync(string albumName, Guid id)
        {
            var albumModel = await _albumRepository.GetNameNotFromThisIdAsync(albumName, id);

            return albumModel == null;
        }
    }
}
