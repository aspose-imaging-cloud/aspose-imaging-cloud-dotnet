using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class UpdateImageApiExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageUpdateExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");


            string fileName = "test.bmp";
            string format = "BMP";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";

            var request = new GetImageUpdateRequest(fileName, format, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod);
            Stream resultStream = imagingApi.GetImageUpdate(request);

            using (var fileStream = new FileStream("output.bmp", FileMode.Create, FileAccess.Write))
            {
                resultStream.CopyTo(fileStream);
            }



        }
    }
}
