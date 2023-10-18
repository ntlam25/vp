using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Admin
{
	public class UserController : Controller
	{
        [Route("/admin/user")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/User/listuser.cshtml");
        }

        [Route("/admin/user/add")]
        public IActionResult Add()
        {
            return View("~/Views/Admin/User/adduser.cshtml");
        }

        [Route("/admin/user/edit")]
        public IActionResult Edit()
        {
            return View("~/Views/Admin/User/edituser.cshtml");
        }
    }
}
