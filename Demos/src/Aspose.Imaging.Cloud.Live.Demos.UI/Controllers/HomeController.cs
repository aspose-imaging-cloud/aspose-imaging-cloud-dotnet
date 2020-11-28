using Aspose.Imaging.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Imaging.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Convert Images, Photos, Pictures Online";
			ViewBag.MetaDescription = "Free online image conversion app for many popular image, photo, picture formats. Convert to PDF, PSD, JPG, GIF, SVG and others, including HTML5 Canvas.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
