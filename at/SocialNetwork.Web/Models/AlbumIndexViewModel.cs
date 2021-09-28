using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;
using SocialNetwork.Web.Controllers;

namespace SocialNetwork.Web.Models
{
    public class AlbumIndexViewModel : IEnumerable
    {
        public IEnumerable<AlbumModel> Albums { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
    