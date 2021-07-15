using Aspose.Imaging.Cloud.Live.Demos.Models;
using Aspose.Imaging.Cloud.Live.Demos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.IO;
using System.Threading.Tasks;


namespace Aspose.Imaging.Cloud.Live.Demos.Controllers
{
    public class ConversionController : BaseController
    {
        public ConversionController(IMemoryCache cache, IAsposeImagingCloudApiService imagingService) : base(cache)
        {
            ImagingService = imagingService;
        }

        public override string Product => (string)RouteData.Values["product"];

        public IAsposeImagingCloudApiService ImagingService { get; }

        public IActionResult Conversion()
        {
            var model = new ViewModel(this, nameof(Conversion))
            {
                SaveAsComponent = true,
                MaximumUploadFiles = 1,
                UseSorting = false
            };

            return View(model);
        }

        [HttpPost]
        public async Task<Response> Conversion(string outputType)
        {
            IFormFile postedFile = Request.Form.Files[0];
            string fileName = postedFile.FileName;
            string fileData = string.Empty;
            string outputFileName = string.Empty;

            using (MemoryStream ms = new MemoryStream())
            {
                await postedFile.CopyToAsync(ms);
                ms.Position = 0;

                string fromFormat = Path.GetExtension(fileName).Substring(1);
                string toFormat = outputType;
                var file = ms;
                outputFileName = Path.GetFileNameWithoutExtension(fileName) + "." + outputType;

                using (MemoryStream convertResult = ImagingService.Convert(file, fileName, toFormat) as MemoryStream)
                {
                    fileData = Convert.ToHexString(convertResult.ToArray());
                }
            }

            return new Response
            {
                StatusCode = 200,
                FileName = outputFileName,
                FileData = fileData
            };
        }

    }
}
