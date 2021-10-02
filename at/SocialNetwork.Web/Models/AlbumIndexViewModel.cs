using System.Collections.Generic;

namespace SocialNetwork.Web.Models
{
    public class AlbumIndexViewModel
    {
        public string Search { get; set; }  
        public IEnumerable<AlbumViewModel> Albums { get; set; }
    }
}
    