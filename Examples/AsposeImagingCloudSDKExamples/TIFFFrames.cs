// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TIFFFrames.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    class TIFFFrames : ImagingBase
    {
        // Get separate frame from existing TIFF image.
        public void GetImageFrameFromStorage()
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

        // Get separate frame from existing TIFF image, and upload the frame to Cloud Storage
        public void GetImageFrameAndUploadToStorage()
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

            using (Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "SingleFrame_out.tiff";
                var uploadFileRequest = new UploadFileRequest(outPath, imageFrame);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Resize a TIFF frame.
        public void ResizeImageFrameFromStorage()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? frameId = 0; // Number of a frame
            int? newWidth = 300;
            int? newHeight = 300;
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(fileName, frameId, newWidth, newHeight,
                                saveOtherFrames: saveOtherFrames, folder: folder, storage: storage);

            Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SingleFrame_out.tiff"))
            {
                imageFrame.Seek(0, SeekOrigin.Begin);
                imageFrame.CopyTo(fileStream);
            }
        }

        // Crop a TIFF frame.
        public void CropImageFrameFromStorage()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? frameId = 0; // Number of a frame
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(fileName, frameId, x: x, y: y, 
                                                            rectWidth: rectWidth, rectHeight: rectHeight, saveOtherFrames: saveOtherFrames, folder: folder, storage: storage);

            Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SingleFrame_out.tiff"))
            {
                imageFrame.Seek(0, SeekOrigin.Begin);
                imageFrame.CopyTo(fileStream);
            }
        }

        // RotateFlip a TIFF frame.
        public void RotateFlipImageFrameFromStorage()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? frameId = 0; // Number of a frame
            string rotateFlipMethod = "Rotate90FlipX";
            // Result will include just the specified frame
            bool? saveOtherFrames = false;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            GetImageFrameRequest getImageFrameRequest = new GetImageFrameRequest(fileName, frameId,
                                rotateFlipMethod: rotateFlipMethod, saveOtherFrames: saveOtherFrames, folder: folder, storage: storage);

            Stream imageFrame = this.ImagingApi.GetImageFrame(getImageFrameRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SingleFrame_out.tiff"))
            {
                imageFrame.Seek(0, SeekOrigin.Begin);
                imageFrame.CopyTo(fileStream);
            }
        }

        // Result will also include all other frames.
        public void GetAllImageFramesFromStorage()
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

        // Get separate frame from existing TIFF image. Image data is passed in a request stream.
        public void CreateImageFrameFromRequestBody()
        {
            string fileName = "Sample.tiff";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
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
        }

        // Get separate frame properties of a TIFF image.
        public void GetImageFramePropertiesFromStorage()
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

        // Get separate frame properties of a TIFF image. Image data is passed in a request stream.
        public void ExtractImageFramePropertiesFromRequestBody()
        {
            string fileName = "Sample.tiff";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                int? frameId = 1;

                ExtractImageFramePropertiesRequest imageFramePropertiesRequest = new ExtractImageFramePropertiesRequest(inputImageStream,
                                                                                                                    frameId);

                ImagingResponse imagingResponse = this.ImagingApi.ExtractImageFrameProperties(imageFramePropertiesRequest);
                Console.WriteLine("Height: " + imagingResponse.Height + "Width: " + imagingResponse.Width);
            }
        }
    }
}
