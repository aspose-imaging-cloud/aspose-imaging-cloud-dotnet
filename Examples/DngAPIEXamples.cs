using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class DngAPIExamples
    {
        protected ImagingApi imagingApi;

        public void getDngAPIEXamples()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");


            string fileName = "test.dng";
            bool? fromScratch = null;
            var request = new GetImageDngRequest(fileName, fromScratch);
            Stream resultStream = imagingApi.GetImageDng(request);


            using (var fileStream = new FileStream("output.dng", FileMode.Create, FileAccess.Write))
            {
                resultStream.CopyTo(fileStream);
            }
        }
    }
}