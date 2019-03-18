using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class SaveAsAPIExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageSaveAsExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string fileName = "test.bmp";
            string format = "BMP";
            var request =
                              new GetImageSaveAsRequest(fileName, format);
            Stream resultStream = imagingApi.GetImageSaveAs(request);

            using (var fileStream = new FileStream("output.bmp", FileMode.Create, FileAccess.Write))
            {
                resultStream.CopyTo(fileStream);
            }
        }
    }
}