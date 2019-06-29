using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples
{
    class ImageProperties : ImagingBase
    {

        // Get properties of an image, which is store in the cloud.
        public void getPropertiesOfAnImageInCloud()
        {
            string fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Get properties of an image
            // Folder with image to process. The value is null because the file is saved at the root of the storage
            string folder = null;
            string storage = null; // We are using default Cloud Storage

            GetImagePropertiesRequest getImagePropertiesRequest = new GetImagePropertiesRequest(fileName, folder,
                                                                                                            storage);

            ImagingResponse imagingResponse = this.ImagingApi.GetImageProperties(getImagePropertiesRequest);
            
        }

        // Get properties of an image.
        // Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
        public void getPropertiesOfAnImageInRequestBody()
        {
            string fileName = "Sample.tiff";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            ExtractImagePropertiesRequest imagePropertiesRequest = new ExtractImagePropertiesRequest(inputImageStream);
            ImagingResponse imagingResponse = this.ImagingApi.ExtractImageProperties(imagePropertiesRequest);
        }

    }
}
