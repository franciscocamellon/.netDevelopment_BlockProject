using System;

namespace SocialNetwork.Domain.Model.Entities
{
    public class AppModel
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
