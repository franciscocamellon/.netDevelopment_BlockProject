using System;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Web.Models
{
    public class PictureViewModel
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        [Required]
        public string UriImageAlbum { get; set; }

        public Guid AlbumId { get; set; }
        public AlbumViewModel Album { get; set; }
        
    }
}
