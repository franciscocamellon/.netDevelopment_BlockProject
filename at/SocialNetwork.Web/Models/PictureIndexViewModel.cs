using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Models
{
    public class PictureIndexViewModel
    {
        public bool OrderAscendant { get; set; }
        public IEnumerable<PictureViewModel> Pictures { get; set; }
    }
}
