// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WMFImage.cs">
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
    class WMFImage : ImagingBase
    {
        // Process existing WMF image using given parameters. The image is saved in the cloud.
        public void ModifyWmfFromStorage()
        {
            string fileName = "Sample.wmf";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string bkColor = "gray";
            int? pageWidth = 300;
            int? pageHeight = 300;
            int? borderX = 50;
            int? borderY = 50;
            bool? fromScratch = null;
            string folder = null;   // Folder with image to process. The value is null because the file is saved at the root of the storage

            string storage = null; // We are using default Cloud Storage
            string exportFormat = "png";

            ModifyWmfRequest getImageWmfRequest = new ModifyWmfRequest(fileName, bkColor, pageWidth, pageHeight,
                                                                    borderX, borderY, fromScratch, folder,
                                                                                                storage, exportFormat);

            Stream updatedImage = this.ImagingApi.ModifyWmf(getImageWmfRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "WMFToPNG_out.png"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Process existing WMF image using given parameters, and upload updated image to Cloud Storage
        public void ModifyWmfAndUploadToStorage()
        {
            string fileName = "Sample.wmf";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string bkColor = "gray";
            int? pageWidth = 300;
            int? pageHeight = 300;
            int? borderX = 50;
            int? borderY = 50;
            bool? fromScratch = null;
            string folder = null;   // Folder with image to process. The value is null because the file is saved at the root of the storage

            string storage = null; // We are using default Cloud Storage
            string exportFormat = "png";

            ModifyWmfRequest getImageWmfRequest = new ModifyWmfRequest(fileName, bkColor, pageWidth, pageHeight,
                                                                    borderX, borderY, fromScratch, folder,
                                                                                                storage, exportFormat);

            using (Stream updatedImage = this.ImagingApi.ModifyWmf(getImageWmfRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "WMFToPNG_out.png";
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Process existing WMF image using given parameters.
        // Image data is passed in a request stream.
        public void CreateModifiedWmfFromRequestBody()
        {
            string fileName = "Sample.wmf";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                string bkColor = "gray";
                int? pageWidth = 300;
                int? pageHeight = 300;
                int? borderX = 50;
                int? borderY = 50;
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage
                string exportFormat = "png";

                CreateModifiedWmfRequest postImageWmfRequest = new CreateModifiedWmfRequest(inputImageStream, bkColor, pageWidth,
                                                                    pageHeight, borderX, borderY, fromScratch, outPath,
                                                                                                    storage, exportFormat);


                Stream updatedImage = this.ImagingApi.CreateModifiedWmf(postImageWmfRequest);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "WMFToPNG_out.png"))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
