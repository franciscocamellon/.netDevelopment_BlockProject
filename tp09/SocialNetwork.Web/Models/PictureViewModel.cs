using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Models
{
    public class PictureViewModel
    {
        public Guid Id { get; set; }
        public DateTime UploadDate { get; set; }    
        public string UriImageAlbum { get; set; }
        public Guid AlbumId { get; set; }
        public AlbumViewModel Album { get; set; }

        public static PictureViewModel From(Picture picture, bool firstMap = true)
        {
            var album = firstMap
                ? AlbumViewModel.From(picture.Album)
                : null;

            var pictureViewModel = new PictureViewModel
            {
                Id = picture.Id,
                UploadDate = picture.UploadDate,
                UriImageAlbum = picture.UriImageAlbum,
                AlbumId = picture.AlbumId,

                Album = album
            };
            return pictureViewModel;
        }

        public Picture ToModel(bool firstMap = true)
        {
            var album = firstMap
                ? Album?.ToModel()
                : null;

            var picture = new Picture
            {
                UploadDate = UploadDate,
                UriImageAlbum = UriImageAlbum,
                AlbumId = AlbumId,

                Album = album
            };
            return picture;
        }
    }
}