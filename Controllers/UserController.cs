using Microsoft.AspNetCore.Mvc;

namespace WebApplication24.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Cowqun";
            ViewBag.Surname = "Eminov";
            ViewBag.Age = 23;
            ViewBag.Country = "AZE";
            ViewBag.PhoneNumber = "099-777";
            return View();
        }
    }
}
