using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Web.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult ChartJs()
        {
            return View();
        }

        public IActionResult ApexchartsJs()
        {
            return View();
        }
    }
}
