using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk;

namespace aspose_imaging_csharp
{
    public class EmfAPIExamples
    {
        protected ImagingApi imagingApi;

        public void getImageEmfExample()
        {
            imagingApi = new ImagingApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");
            string name = "test.emf";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            bool? fromScratch = null;
            var request = new GetImageEmfRequest(name, bkColor, pageWidth, pageHeigth, borderX, borderY,
                           fromScratch);
            Stream stream = imagingApi.GetImageEmf(request);


            using (var fileStream = new FileStream("output.emf", FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }
        }
    }
}