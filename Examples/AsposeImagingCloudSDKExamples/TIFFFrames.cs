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
    class TIFFFrames : ImagingBase
    {
        // Get separate frame from existing TIFF image.
        public void getAFrameFromTIFFImageInCloud()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? frameId = 1; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(fileName, frameId, newWidth, newHeight,
                            x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, folder, storage);

            Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SingleFrame_out.tiff"))
            {
                imageFrame.Seek(0, SeekOrigin.Begin);
                imageFrame.CopyTo(fileStream);
            }
        }

        // Get other frames from TIFF image.
        public void getOtherFramesFromTIFFImageInCloud()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? frameId = 1; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include all other frames
            bool? saveOtherFrames = true;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(fileName, frameId, newWidth, newHeight,
                    x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, folder, storage);

            Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "OtherFrames_out.tiff"))
            {
                imageFrame.Seek(0, SeekOrigin.Begin);
                imageFrame.CopyTo(fileStream);
            }
        }

        // Get separate frame from existing TIFF image. Image is passed in a request stream.
        public void getAFrameFromTIFFImageInRequestBody()
        {
            string fileName = "Sample.tiff";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            int? frameId = 1;
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            bool? saveOtherFrames = false;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
            string storage = null; // We are using default Cloud Storage

            CreateImageFrameRequest createImageFrameRequest = new CreateImageFrameRequest(inputImageStream, frameId, newWidth,
                        newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, saveOtherFrames, outPath, storage);

            Stream imageFrame = this.ImagingApi.CreateImageFrame(createImageFrameRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SingleFrame_out.tiff"))
            {
                imageFrame.Seek(0, SeekOrigin.Begin);
                imageFrame.CopyTo(fileStream);
            }
        }

        // Get separate frame properties of existing TIFF image.
        public void getFramePropertiesOfTIFFImageInCloud()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? frameId = 1; // Number of a frame
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFramePropertiesRequest imageFramePropertiesRequest = new GetImageFramePropertiesRequest(fileName,
                                                                                                frameId, folder, storage);

            ImagingResponse imagingResponse = this.ImagingApi.GetImageFrameProperties(imageFramePropertiesRequest);
            Console.WriteLine("Height: " + imagingResponse.Height + "Width: " + imagingResponse.Width);
        }

        // Get separate frame properties of existing TIFF image. Image is passed in a request stream.
        public void getFramePropertiesOfTIFFImageInRequestBody()
        {
            string fileName = "Sample.tiff";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            int? frameId = 1;

            ExtractImageFramePropertiesRequest imageFramePropertiesRequest = new ExtractImageFramePropertiesRequest(inputImageStream,
                                                                                                                frameId);

            ImagingResponse imagingResponse = this.ImagingApi.ExtractImageFrameProperties(imageFramePropertiesRequest);
            Console.WriteLine("Height: " + imagingResponse.Height + "Width: " + imagingResponse.Width);
        }
    }
}
