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
    class UpdateBMPImage : ImagingBase
    {
        // Update parameters of existing BMP image. The image is saved in the cloud. 
        public void updateParametersOfBMPImageInCloud()
        {
            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            var request = new ModifyBmpRequest(fileName, bitsPerPixel, horizontalResolution, 
                                        verticalResolution, fromScratch, folder, storage);
            Stream updatedImage = this.ImagingApi.ModifyBmp(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out.bmp"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of existing BMP image. Image is passed in a request stream.
        public void updateParametersOfBMPImageInRequestBody()
        {
            string fileName = "WaterMark.bmp";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
            string storage = null; // We are using default Cloud Storage

            var request = new CreateModifiedBmpRequest(inputImageStream, bitsPerPixel, horizontalResolution, verticalResolution, fromScratch, outPath, storage);
            Stream updatedImage = this.ImagingApi.CreateModifiedBmp(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out.bmp"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
