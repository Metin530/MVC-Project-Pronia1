using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_Pronia.Controllers
{
    public class SinglePage
    {
        public class SinglePageController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    }
}
