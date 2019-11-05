// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateJPEGImage.cs">
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
    class UpdateJPEGImage : ImagingBase
    {
        // Update parameters of existing JPEG image. The image is saved in the cloud.
        public void ModifyJpegFromStorage()
        {
            string fileName = "aspose-logo.jpg";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
            
            int? quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            ModifyJpegRequest modifyJpegRequest = new ModifyJpegRequest(fileName, quality, compressionType,
                                                                                fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyJpeg(modifyJpegRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jpg"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of existing JPEG image, and upload updated image to Cloud Storage
        public void ModifyJpegAndUploadToStorage()
        {
            string fileName = "aspose-logo.jpg";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            int? quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            ModifyJpegRequest modifyJpegRequest = new ModifyJpegRequest(fileName, quality, compressionType,
                                                                                fromScratch, folder, storage);

            using (Stream updatedImage = this.ImagingApi.ModifyJpeg(modifyJpegRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Sample_out.jpg";
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Update parameters of existing JPEG image. Image data is passed in a request stream.
        public void CreateModifiedJpegFromRequestBody()
        {
            string fileName = "aspose-logo.jpg";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                int? quality = 65;
                string compressionType = "progressive";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                CreateModifiedJpegRequest modifiedJpgRequest = new CreateModifiedJpegRequest(inputImageStream, quality, compressionType,
                                                                                            fromScratch, outPath, storage);

                Stream updatedImage = this.ImagingApi.CreateModifiedJpeg(modifiedJpgRequest);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jpg"))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
