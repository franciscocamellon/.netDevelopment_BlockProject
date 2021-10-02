using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SocialNetwork.Domain.Model.Entities;
using SocialNetwork.Domain.Model.Interfaces.Repositories;
using SocialNetwork.Domain.Model.Interfaces.Services;

namespace SocialNetwork.Domain.Services.Services
{
    public class PictureServices : IPictureService
    {
        private readonly IPictureRepository _pictureRepository;

        public PictureServices(IPictureRepository pictureRepository)    
        {
            _pictureRepository = pictureRepository;
        }
        public async Task<IEnumerable<PictureModel>> GetPicturesByAlbumIdAsync(Guid albumId)
        {
            return await _pictureRepository.GetPicturesByAlbumIdAsync(albumId);
        }

        public async Task<IEnumerable<PictureModel>> GetAllAsync(bool orderAscendant = true)
        {
            return await _pictureRepository.GetAllAsync(orderAscendant);
        }

        public async Task<PictureModel> GetByIdAsync(Guid id)
        {
            return  await _pictureRepository.GetByIdAsync(id);
        }

        public async Task<PictureModel> CreateAsync(PictureModel pictureModel)
        {
            return await _pictureRepository.CreateAsync(pictureModel);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _pictureRepository.DeleteAsync(id); 
        }
    }
}
