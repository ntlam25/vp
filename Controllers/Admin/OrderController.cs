using Microsoft.AspNetCore.Mvc;

namespace vphone.Controllers.Admin
{
	public class OrderController : Controller
	{
		[Route("/admin/order")]
		public IActionResult Order()
		{
			return View("~/Views/Admin/Order/order.cshtml");
		}

		[Route("/admin/order/detail")]
		public IActionResult OrderDetail ()
		{
			return View("~/Views/Admin/Order/detailorder.cshtml");
		}


		[Route("/admin/order/processed")]
		public IActionResult Processed ()
		{
			return View("~/Views/Admin/Order/processed.cshtml");
		}
		
	}
}
