// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WEBPImage.cs">
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
    class WEBPImage : ImagingBase
    {
        // Update parameters of existing WEBP image. The image is saved in the cloud.
        public void ModifyWebPFromStorage()
        {
            String fileName = "asposelogo.webp";
            
            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            bool? lossless = true;
            int? quality = 90;
            int? animLoopCount = 5;
            string animBackgroundColor = "gray";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            string folder = null; // Folder with image to process. The value is null because the file is saved at the root of the storage
            String storage = null; // We are using default Cloud Storage

            ModifyWebPRequest getImageWebPRequest = new ModifyWebPRequest(fileName, lossless, quality,
                                            animLoopCount, animBackgroundColor, fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyWebP(getImageWebPRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "asposelogo_out.webp"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of existing WEBP image, and upload updated image to Cloud Storage
        public void ModifyWebPAndUploadToStorage()
        {
            String fileName = "asposelogo.webp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            bool? lossless = true;
            int? quality = 90;
            int? animLoopCount = 5;
            string animBackgroundColor = "gray";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            string folder = null; // Folder with image to process. The value is null because the file is saved at the root of the storage
            String storage = null; // We are using default Cloud Storage

            ModifyWebPRequest getImageWebPRequest = new ModifyWebPRequest(fileName, lossless, quality,
                                            animLoopCount, animBackgroundColor, fromScratch, folder, storage);

            using (Stream updatedImage = this.ImagingApi.ModifyWebP(getImageWebPRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "asposelogo_out.webp";
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Update parameters of existing Webp image. asposelogo.webpImage data is passed in a request stream.
        public void CreateModifiedWebPFromRequestBody()
        {
            string fileName = "asposelogo.webp";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                bool? lossless = true;
                int? quality = 90;
                int? animLoopCount = 5;
                string animBackgroundColor = "gray";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                CreateModifiedWebPRequest modifiedImageWebPRequest = new CreateModifiedWebPRequest(inputImageStream, lossless, quality,
                                                        animLoopCount, animBackgroundColor, fromScratch, outPath, storage);

                Stream updatedImage = this.ImagingApi.CreateModifiedWebP(modifiedImageWebPRequest);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "asposelogo_out.webp"))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
