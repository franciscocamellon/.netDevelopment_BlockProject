using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Web.Controllers;

namespace SocialNetwork.Web.Models
{
    public class AlbumIndexViewModel
    {
        public string Search { get; set; }  
        public IEnumerable<AlbumViewModel> Albums { get; set; }
    }
}
    