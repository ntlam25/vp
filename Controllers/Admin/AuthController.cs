using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Admin
{
	public class AuthController : Controller
	{
		[Route("admin/login")]
		public IActionResult Index()
		{
			return View("~/Views/Admin/Auth/login.cshtml");
		}
	}
}
