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
    class UpdatePSDImage : ImagingBase
    {
        // Update parameters of existing PSD image. The image is saved in the cloud.
        public void updateParametersOfPSDImageInCloud()
        {
            string fileName = "Sample.psd";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? channelsCount = 3;
            string compressionMethod = "raw";
            bool? fromScratch = null;
            string folder = null;
            string storage = null; // We are using default Cloud Storage

            ModifyPsdRequest modifyPsdRequest = new ModifyPsdRequest(fileName, channelsCount, compressionMethod,
                                                                                fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyPsd(modifyPsdRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.psd"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
        
        // Update parameters of existing PSD image. Image is passed in a request stream.
        public void updateParametersOfPSDImageInRequestBody()
        {
            string fileName = "Sample.psd";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);
            
            int? channelsCount = 3;
            string compressionMethod = "raw";
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
            string storage = null; // We are using default Cloud Storage

            CreateModifiedPsdRequest modifiedPsdRequest = new CreateModifiedPsdRequest(inputImageStream, channelsCount,
                                                                    compressionMethod, fromScratch, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateModifiedPsd(modifiedPsdRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.psd"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
