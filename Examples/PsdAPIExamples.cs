using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class PsdAPIExamples
    {
        protected ImagingApi imagingApi;
        public void GetImagePsdExample()
        {
            string name = "test.bmp";
            int channelsCount = 3;
            string compressionMethod = "raw";
            bool? fromScratch = null;
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            var request = new GetImagePsdRequest(name, channelsCount, compressionMethod, fromScratch);
            Stream result = imagingApi.GetImagePsd(request);

            using (var fileStream = new FileStream("output.psd", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fileStream);
            }
        }
    }
}