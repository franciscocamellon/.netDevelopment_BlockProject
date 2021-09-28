using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class Picture
    {
        public Guid Id { get; set; }
        public DateTime UploadDate { get; set; }    
        public string UriImageAlbum { get; set; }
        public Album Album { get; set; }
        public Guid AlbumId { get; set; }
    }
}