using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Web.Controllers
{
    public class FeedController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
