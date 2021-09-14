using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Web.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult TableElements()
        {
            return View();
        }

        public IActionResult TablePlugins()
        {
            return View();
        }
    }
}
