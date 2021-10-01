using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Web.Models
{
    public class AppIndexViewModel
    {
        public string Search { get; set; }  
        public IEnumerable<AppViewModel> Apps { get; set; }
    }
}
