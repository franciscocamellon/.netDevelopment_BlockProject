using System;

namespace SocialNetwork.Domain.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime GraduationDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PublishedApps { get; set; }
        public string UserId { get; set; }
    }
}
