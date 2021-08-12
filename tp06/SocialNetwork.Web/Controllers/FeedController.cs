using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Web.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
