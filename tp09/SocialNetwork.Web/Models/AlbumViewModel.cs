using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Web.Models
{
    public class AlbumViewModel
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<PictureViewModel> Pictures { get; set; }

        public static AlbumViewModel From(Album album)
        {
            var albumViewModel = new AlbumViewModel
            {
                Id = album.Id,
                AlbumName = album.AlbumName,
                CreationDate = album.CreationDate,

                Pictures = album?.Pictures.Select(x => PictureViewModel.From(x, false)).ToList(),
            };
            return albumViewModel;
        }

        public Album ToModel()
        {
            var album = new Album
            {
                Id = Id,
                AlbumName = AlbumName,
                CreationDate = CreationDate,

                Pictures = Pictures?.Select(x => x.ToModel(false)).ToList(),
            };

            return album;
        }
    }
}