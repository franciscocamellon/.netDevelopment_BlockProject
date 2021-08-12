using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Web.Controllers
{
    public class PagesController : Controller
    {
       
        public IActionResult Products()
        {
            return View();
        }
        
    	public IActionResult Orders()
        {
            return View();
        }
        
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult SearchResults()
        {
            return View();
        }

        public IActionResult ComingSoonPage()
        {
            return View();
        }

        public IActionResult ErrorPage()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

    }
}
