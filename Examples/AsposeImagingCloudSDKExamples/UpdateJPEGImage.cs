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
    class UpdateJPEGImage : ImagingBase
    {
        // Update parameters of existing JPEG image. The image is saved in the cloud.
        public void updateParametersOfJPEGImageInCloud()
        {
            string fileName = "aspose-logo.jpg";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
            
            int? quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            ModifyJpegRequest modifyJpegRequest = new ModifyJpegRequest(fileName, quality, compressionType,
                                                                                fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyJpeg(modifyJpegRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jpg"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
        
        // Update parameters of existing JPEG image. Image is passed in a request stream.
        public void updateParametersOfJPEGImageInRequestBody()
        {
            string fileName = "aspose-logo.jpg";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            int? quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
            string storage = null; // We are using default Cloud Storage

            CreateModifiedJpegRequest modifiedJpgRequest = new CreateModifiedJpegRequest(inputImageStream, quality, compressionType,
                                                                                        fromScratch, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateModifiedJpeg(modifiedJpgRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jpg"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
