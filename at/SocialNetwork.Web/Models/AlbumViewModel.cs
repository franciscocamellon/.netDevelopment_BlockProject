using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int? NumberOfPictures { get; set; }
        public Profile Profile { get; set; } 
        public int ProfileId { get; set; }
        public List<PictureViewModel> Pictures { get; set; }

    }
}
