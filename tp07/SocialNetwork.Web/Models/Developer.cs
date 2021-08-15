using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Models
{
    public class Developer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool EmployedStatus { get; set; }
        public int PublishedApps { get; set; }
    }
}
