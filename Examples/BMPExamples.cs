using System;
using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;



namespace aspose_imaging_csharp
{
    class BMPImagingExamples
    {
        protected ImagingApi imagingApi;

        public void getImageBMPExample()
        {
            string fileName = "test.bmp";
            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;

            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            var request = new GetImageBmpRequest(fileName, bitsPerPixel, horizontalResolution, verticalResolution, fromScratch);
            Stream response = imagingApi.GetImageBmp(request);
        }

        public void postImageBMPEample()
        {
            string name = "c:\\test.bmp";
            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

            FileStream stream = File.Open(name, FileMode.Open);
            var request = new PostImageBmpRequest(stream, bitsPerPixel, horizontalResolution, verticalResolution, fromScratch);
            var response =imagingApi.PostImageBmp(request);

            Console.WriteLine(response);
        }
    }
}

