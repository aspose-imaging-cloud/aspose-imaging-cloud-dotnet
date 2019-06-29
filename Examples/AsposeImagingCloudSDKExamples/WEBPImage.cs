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
    class WEBPImage : ImagingBase
    {
        // Update parameters of existing WEBP image. The image is saved in the cloud.
        public void updateParametersOfWEBPImageInCloud()
        {
            String fileName = "asposelogo.webp";
            
            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            bool? lossless = true;
            int? quality = 90;
            int? animLoopCount = 5;
            string animBackgroundColor = "gray";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            string folder = null; // Folder with image to process. The value is null because the file is saved at the root of the storage
            String storage = null; // We are using default Cloud Storage

            ModifyWebPRequest getImageWebPRequest = new ModifyWebPRequest(fileName, lossless, quality,
                                            animLoopCount, animBackgroundColor, fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyWebP(getImageWebPRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "asposelogo_out.webp"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of existing Webp image. asposelogo.webpImage data is passed as zero-indexed multipart/form-data
        // content or as raw body stream.
        public void updateParametersOfWEBPImageInRequestBody()
        {
            string fileName = "asposelogo.webp";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            bool? lossless = true;
            int? quality = 90;
            int? animLoopCount = 5;
            string animBackgroundColor = "gray";
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
            string storage = null; // We are using default Cloud Storage

            CreateModifiedWebPRequest modifiedImageWebPRequest = new CreateModifiedWebPRequest(inputImageStream, lossless, quality,
                                                    animLoopCount, animBackgroundColor, fromScratch, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateModifiedWebP(modifiedImageWebPRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "asposelogo_out.webp"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
