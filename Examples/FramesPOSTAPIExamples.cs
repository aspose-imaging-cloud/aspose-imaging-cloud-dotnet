using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class FramePostAPIxamples
    {
        protected ImagingApi imagingApi;
        public void PostImageSingleFrameExample()
        {
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
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

            FileStream inputStream = File.Open(name, FileMode.Open);
            var request = new PostImageFrameRequest(inputStream, frameId, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod,
                saveOtherFrames);
            Stream result = imagingApi.PostImageFrame(request);

            using (var fileStream = new FileStream("output.tiff", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fileStream);
            }



        }
    }
}