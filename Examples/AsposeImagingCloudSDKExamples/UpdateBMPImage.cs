// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateBMPImage.cs">
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
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    class UpdateBMPImage : ImagingBase
    {
        // Update parameters of a BMP image. The image is saved in the cloud. 
        public void ModifyBmpFromStorage()
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

        // Update parameters of a BMP image, and upload updated image to Cloud Storage.
        public void ModifyBmpAndUploadToStorage()
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
            using (Stream updatedImage = this.ImagingApi.ModifyBmp(request))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Watermark_out.bmp";
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Update parameters of a BMP image. Image data is passed in a request stream.
        public void CreateModifiedBmpFromRequestBody()
        {
            string fileName = "WaterMark.bmp";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
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
}
