using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Site
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
