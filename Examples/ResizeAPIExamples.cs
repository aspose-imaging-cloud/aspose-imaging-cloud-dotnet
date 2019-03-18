using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class ResizeAPIExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageResizeExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");


            string fileName = "test.bmp";
            string format = "BMP";

            int? newWidth = 100;
            int? newHeight = 150;

            var request = new GetImageResizeRequest(fileName, format, newWidth, newHeight);
            var stream = imagingApi.GetImageResize(request);

            using (var fileStream = new FileStream("output.bmp", FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }


        }
    }
}