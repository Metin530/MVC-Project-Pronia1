using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_Pronia.Controllers
{
    public class ErrorController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
