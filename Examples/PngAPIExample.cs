using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class PngAPIExamples
    {
        protected ImagingApi imagingApi;
        public void GetImagePngExample()
        {
            string fileName = "test.png";
            bool? fromScratch = false;
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            var request = new GetImagePngRequest(fileName, fromScratch);
            var resultStream = imagingApi.GetImagePng(request);

            using (var fileStream = new FileStream("output.png", FileMode.Create, FileAccess.Write))
            {
                resultStream.CopyTo(fileStream);
            }
        }
    }
}