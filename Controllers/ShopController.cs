using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_Pronia.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
        public IActionResult SinglePage()
        {
            return View();
        }
    }
}
