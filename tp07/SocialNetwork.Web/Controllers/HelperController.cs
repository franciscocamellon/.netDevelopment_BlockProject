using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Web.Controllers
{
    public class HelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
