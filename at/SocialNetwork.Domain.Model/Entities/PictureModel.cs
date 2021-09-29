using System;

namespace SocialNetwork.Domain.Entities
{
    public class PictureModel
    {
        public Guid Id { get; set; }
        public DateTime UploadDate { get; set; }    
        public string UriImageAlbum { get; set; }

        public Guid AlbumId { get; set; }
        public AlbumModel Album { get; set; }
    }
}
