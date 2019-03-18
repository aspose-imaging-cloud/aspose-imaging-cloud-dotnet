using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class WmfApiExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageWmfExample()
        {

            string name = "test.wmf";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            bool? fromScratch = null;
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string fileName = "Animation.webp";


            var request = new GetImageWmfRequest(name, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch);
            Stream result = imagingApi.GetImageWmf(request);

            using (var fileStream = new FileStream("output.wmf", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fileStream);
            }
        }
    }
}