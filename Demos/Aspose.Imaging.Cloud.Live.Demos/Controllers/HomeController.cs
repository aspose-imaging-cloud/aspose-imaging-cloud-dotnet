using Aspose.Imaging.Cloud.Live.Demos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Aspose.Imaging.Cloud.Live.Demos.Controllers
{
    public class HomeController : BaseController
    {
        public override string Product => string.Empty;

        public HomeController(IMemoryCache cache) : base(cache)
        {
        }

        public IActionResult Default()
        {
            ViewBag.PageTitle = Resources["imagingConversionPageTitle"];
            ViewBag.MetaDescription = Resources["imagingConversionMetaDescription"];

            var model = new LandingPageModel(this);
            return View(model);
        }
    }
}
