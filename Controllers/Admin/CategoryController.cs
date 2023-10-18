using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Admin
{
	public class CategoryController : Controller
	{
		[Route("/admin/category")]
		public IActionResult Index()
		{
			return View("~/Views/Admin/Category/category.cshtml");
		}

		[Route("/admin/category/add")]
		public IActionResult Add()
		{
			return View("~/Views/Admin/Category/addcategory.cshtml");
		}

		[Route("/admin/category/edit")]
		public IActionResult Edit()
		{
			return View("~/Views/Admin/Category/editcategory.cshtml");
		}
	}
}
