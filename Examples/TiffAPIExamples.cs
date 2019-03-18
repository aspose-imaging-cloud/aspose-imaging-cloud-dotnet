using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class TiffAPIExamples
    {
        protected ImagingApi imagingApi;
        public void GetTiffToFaxExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string name = "test.tiff";
            var request = new GetTiffToFaxRequest(name);
            var result = imagingApi.GetTiffToFax(request);

            using (var fileStream = new FileStream("output.tiff", FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(fileStream);
            }


        }
    }
}