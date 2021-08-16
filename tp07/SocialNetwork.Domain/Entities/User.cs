using Microsoft.AspNetCore.Identity;
using System;

namespace SocialNetwork.Domain.Entities
{
    public class User : IdentityUser
    {

        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public DateTime GraduationDate { get; set; }
        
    }
}
