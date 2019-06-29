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
    class UpdateGIFImage : ImagingBase
    {
        // Update parameters of existing GIF image. The image is saved in the cloud.
        public void updateParametersOfGIFImageInCloud()
        {
            string fileName = "Sample.gif";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? backgroundColorIndex = 5;
            int? colorResolution = 4;
            bool? hasTrailer = true;
            bool? interlaced = false;
            bool? isPaletteSorted = true;
            int? pixelAspectRatio = 4;
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            ModifyGifRequest getImageGifRequest = new ModifyGifRequest(fileName, backgroundColorIndex,
                                                            colorResolution, hasTrailer, interlaced, isPaletteSorted,
                                                            pixelAspectRatio, fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyGif(getImageGifRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.gif"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of GIF image. Image is passed in a request stream.
        public void updateParametersOfGIFImageInRequestBody()
        {
            string fileName = "Sample.gif";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            int? backgroundColorIndex = 5;
            int? colorResolution = 4;
            bool? hasTrailer = true;
            bool? interlaced = false;
            bool? isPaletteSorted = true;
            int? pixelAspectRatio = 4;
            bool? fromScratch = null;
            string outPath = null;
            string storage = null; // We are using default Cloud Storage

            CreateModifiedGifRequest postImageGifRequest = new CreateModifiedGifRequest(inputImageStream, backgroundColorIndex,
                                            colorResolution, hasTrailer, interlaced, isPaletteSorted, pixelAspectRatio,
                                                                                        fromScratch, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateModifiedGif(postImageGifRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.gif"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
