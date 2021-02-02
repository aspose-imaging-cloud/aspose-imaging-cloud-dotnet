using Aspose.Imaging.Cloud.Live.Demos.UI.Models;
using System.Web.Mvc;

namespace Aspose.Imaging.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = Resources["imagingConversionPageTitle"];
			ViewBag.MetaDescription = Resources["imagingConversionMetaDescription"];

			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
