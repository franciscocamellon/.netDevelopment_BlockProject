using System.Collections.Generic;

namespace SocialNetwork.Web.Models
{
    public class PictureIndexViewModel
    {
        public bool OrderAscendant { get; set; }
        public IEnumerable<PictureViewModel> Pictures { get; set; }
    }
}
