using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class Album
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public DateTime CreationDate { get; set; }
        public Profile Profile { get; set; } 
        public int ProfileId { get; set; }

    }
}
