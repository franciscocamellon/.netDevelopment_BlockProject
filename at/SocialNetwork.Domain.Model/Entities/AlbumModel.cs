using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Domain.Entities
{
    public class AlbumModel
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public DateTime CreationDate { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public List<PictureModel> Pictures { get; set; }

        [NotMapped]
        public int? NumberOfPictures { get; set; } 

    }
}
