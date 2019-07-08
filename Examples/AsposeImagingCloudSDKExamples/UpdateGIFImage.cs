// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateGIFImage.cs">
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
    class UpdateGIFImage : ImagingBase
    {
        // Update parameters of existing GIF image. The image is saved in the cloud.
        public void ModifyGifFromStorage()
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

        // Update parameters of existing GIF image. The image is saved in the cloud.
        public void ModifyGifAndUploadToStorage()
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

            using (Stream updatedImage = this.ImagingApi.ModifyGif(getImageGifRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Sample_out.gif";
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Update parameters of GIF image. Image data is passed in a request stream.
        public void CreateModifiedGifFromRequestBody()
        {
            string fileName = "Sample.gif";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
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
}
