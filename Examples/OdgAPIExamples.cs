using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class OdgAPIExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageOdgExample()
        {
            string fileName = "test.bmp";
            bool? fromScratch = null;
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            var request = new GetImageOdgRequest(fileName, fromScratch);
            var stream = imagingApi.GetImageOdg(request);

            using (var fileStream = new FileStream("output.odg", FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }
        }
    }
}