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
        
    }
}
