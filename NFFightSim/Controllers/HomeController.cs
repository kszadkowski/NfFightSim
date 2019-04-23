using System.Web.Mvc;

namespace NFFightSim.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ViewResult Highlander()
		{
			ViewBag.Title = "Highlander";
			return View();
		}

		public ViewResult Kingslayers()
		{
			ViewBag.Title = "Kingslayers";
			return View();
		}


		public ViewResult WeaponMaster()
		{
			ViewBag.Title = "WeaponMaster";
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}