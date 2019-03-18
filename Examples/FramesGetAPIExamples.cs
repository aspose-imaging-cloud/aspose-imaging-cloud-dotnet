using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class FrameGetAPIxamples
    {
        protected ImagingApi imagingApi;

        public void GetImageSingleFrameExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string name = "test.tiff";
            int? frameId = 2;
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            bool? saveOtherFrames = false;


            var request = new GetImageFrameRequest(name, frameId, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod,
                        saveOtherFrames);
            Stream stream = imagingApi.GetImageFrame(request);


            using (var fileStream = new FileStream("output.tiff", FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }
        }
    }
}