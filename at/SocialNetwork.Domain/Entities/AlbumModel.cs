using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class AlbumModel
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public DateTime CreationDate { get; set; }
        public int? NumberOfPictures { get; set; }   
        public Profile Profile { get; set; } 
        public int ProfileId { get; set; }
        public List<PictureModel> Pictures { get; set; }

    }
}
