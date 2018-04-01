namespace WeddingTemplate.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Turkey()
        {
            return View("Turkey");
        }
    }
}
