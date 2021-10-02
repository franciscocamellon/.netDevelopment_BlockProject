using System;
using SocialNetwork.Domain.Model.Entities;

namespace SocialNetwork.Web.Models
{
    public class AppViewModel
    {
        public Guid Id { get; set; }
        public string AppName { get; set; }
        public string Platform { get; set; }
        public bool PublishedStatus { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
