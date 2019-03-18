using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class JPEG2000APIExamples
    {
        protected ImagingApi imagingApi;
        public void GetImageJpeg2000Example()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string name = "test.j2k";
            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            var request = new GetImageJpeg2000Request(name, comment, codec, fromScratch);
            Stream result = imagingApi.GetImageJpeg2000(request);

            using (var fileStream = new FileStream("output.j2k", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fileStream);
            }
        }
    }
}