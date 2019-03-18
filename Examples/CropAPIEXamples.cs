using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class CropAPIExamples
    {
        protected ImagingApi imagingApi;

        public void getImageCropExamples()
        {
            string fileName = "test.bmp";
            int? x = 10;
            int? y = 10;
            int? width = 100;
            int? height = 150;

            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            var request = new GetImageCropRequest(fileName, "JPG", x, y, width, height);
            Stream stream = imagingApi.GetImageCrop(request);

            using (var fileStream = new FileStream("output.jpg", FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }

        }
    }
}