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
    class UpdateImage : ImagingBase
    {
        // Perform scaling, cropping and flipping of an existing image in a single request. 
        // The image is saved in the cloud.
        public void updateImageInCloud()
        {
            string fileName = "Sample.gif";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string format = "pdf";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            UpdateImageRequest getImageUpdateRequest = new UpdateImageRequest(fileName, format, newWidth,
                                newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, folder, storage);

            Stream updatedImage = this.ImagingApi.UpdateImage(getImageUpdateRequest); ;
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
        
        // Perform scaling, cropping and flipping of an image in a single request.
        // Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
        public void updateImageInRequestBody()
        {
            string fileName = "Sample.gif";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            string format = "pdf";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
            string storage = null; // We are using default Cloud Storage

            CreateUpdatedImageRequest postImageUpdateRequest = new CreateUpdatedImageRequest(inputImageStream, format, newWidth,
                                        newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateUpdatedImage(postImageUpdateRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
