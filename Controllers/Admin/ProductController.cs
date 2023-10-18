using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Admin
{
	public class ProductController : Controller
	{
		[Route("/admin/product")]
		public IActionResult Index()
		{
			return View("~/Views/Admin/Product/listproduct.cshtml");
		}

        [Route("/admin/product/add")]
        public IActionResult Add()
        {
            return View("~/Views/Admin/Product/addproduct.cshtml");
        }

        [Route("/admin/product/edit")]
        public IActionResult Edit()
        {
            return View("~/Views/Admin/Product/editproduct.cshtml");
        }
    }
}
