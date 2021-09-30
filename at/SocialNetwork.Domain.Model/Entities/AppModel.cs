using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Model.Entities
{
    public class AppModel
    {
        public Guid Id { get; set; }
        public string AppName { get; set; }
        public bool PublishedStatus { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public List<PictureModel> Pictures { get; set; }
        
    }
}
