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
    class RotateFlipAnImage : ImagingBase
    {
        // Rotate and/or flip an existing image.
        public void rotateFlipAnImageInCloud()
        {
            string fileName = "Sample.psd";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string format = "gif";
            string method = "Rotate90FlipX"; // RotateFlip method
            string folder = null; // Folder with image to process.
            string storage = null; // We are using default Cloud Storage

            RotateFlipImageRequest getImageRotateFlipRequest = new RotateFlipImageRequest(fileName, format,
                                                                                method, folder, storage);

            Stream updatedImage = this.ImagingApi.RotateFlipImage(getImageRotateFlipRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        
        // Rotate and/or flip an existing image.
        // Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
        public void rotateFlipAnImageInRequestBody()
        {   
            string fileName = "Sample.psd";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            String format = "gif";
            String method = "Rotate90FlipX"; // RotateFlip method
            String outPath = null; // Path to updated file (if this is empty, response contains streamed image).
            String storage = null; // We are using default Cloud Storage

            CreateRotateFlippedImageRequest createRotateFlippedImageRequest = new CreateRotateFlippedImageRequest(inputImageStream, format,
                                                                                            method, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateRotateFlippedImage(createRotateFlippedImageRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
