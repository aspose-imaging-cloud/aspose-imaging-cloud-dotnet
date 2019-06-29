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
    class ResizeImage : ImagingBase
    {       
        // Resize an existing image.
        public void resizeAnImageInCloud()
        {
            string fileName = "Sample.psd";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
            
            string format = "gif";
            int? newWidth = 100;
            int? newHeight = 150;
            string folder = null; // Folder with image to process.
            string storage = null; // We are using default Cloud Storage

            ResizeImageRequest resizeImageRequest = new ResizeImageRequest(fileName, format, newWidth,
                                                                                newHeight, folder, storage);

            Stream updatedImage = this.ImagingApi.ResizeImage(resizeImageRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        
        // Resize an existing image. Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
        public void resizeAnImageInRequestBody()
        {
            string fileName = "Sample.psd";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            string format = "gif";
            int? newWidth = 100;
            int? newHeight = 150;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
            string storage = null; // We are using default Cloud Storage

            CreateResizedImageRequest createResizedImageRequest = new CreateResizedImageRequest(inputImageStream, format, newWidth,
                                                                                        newHeight, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateResizedImage(createResizedImageRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
