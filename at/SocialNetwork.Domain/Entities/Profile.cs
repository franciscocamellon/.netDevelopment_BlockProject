using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SocialNetwork.Domain.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool EmployedStatus { get; set; }
        public int? PublishedApps { get; set; }
        public string Bio { get; set; }
        public string UriImageProfile { get; set; }
        public string UserId { get; set; }
        public List<AlbumModel> Albums { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
