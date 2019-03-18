using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class WebPApiExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageWebExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string fileName = "Animation.webp";
            bool lossless = true;
            int quality = 90;
            int animLoopCount = 5;
            string animBackgroundColor = "gray";
            bool? fromScratch = null;

            var request = new GetImageWebPRequest(fileName, lossless, quality, animLoopCount, animBackgroundColor, fromScratch);
            Stream result = imagingApi.GetImageWebP(request);

            using (var fileStream = new FileStream("output.webp", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fileStream);
            }

        }
    }
}