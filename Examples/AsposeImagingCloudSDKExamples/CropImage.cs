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
    class CropImage : ImagingBase
    {
        // Crop an existing image
        public void cropImageInCloud()
        {
            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string format = "jpg"; // Resulting image format. Currently, BMP, PSD, JPG, TIFF, GIF, PNG, J2K and WEBP are supported.
            int? x = 10;
            int? y = 10;
            int? width = 100;
            int? height = 150;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            var request = new CropImageRequest(fileName, format, x, y, width, height, folder, storage);
            Stream updatedImage = this.ImagingApi.CropImage(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        //  Crop an existing image. Image is passed in a request stream.
        public void cropImageInRequestBody()
        {
            string fileName = "WaterMark.bmp";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            string format = "jpg"; // Resulting image format. Currently, BMP, PSD, JPG, TIFF, GIF, PNG, J2K and WEBP are supported.
            int? x = 10;
            int? y = 10;
            int? width = 100;
            int? height = 150;
            string storage = null; // We are using default Cloud Storage
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)

            var request = new CreateCroppedImageRequest(inputImageStream, format, x, y, width, height, outPath, storage);
            Stream updatedImage = this.ImagingApi.CreateCroppedImage(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
