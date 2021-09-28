using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Web.Models
{
    public class AlbumIndexViewModel
    {
        public IEnumerable<Album> Albums { get; set; }
    }
}