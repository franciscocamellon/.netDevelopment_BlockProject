using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Web.Models
{
    public class AlbumViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 5)]
        [Display(Name = "Nome do álbum")]
        public string AlbumName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [NotMapped]
        public int? NumberOfPictures { get; set; } 

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public List<PictureViewModel> Pictures { get; set; }

        

    }
}
