// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateEMFImageProperties.cs">
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
    class UpdateEMFImage : ImagingBase
    {
        //  Process existing EMF imaging using given parameters
        public void ModifyEmfFromStorage()
        {
            string fileName = "Sample.emf";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            string format = "png";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // As we are using default Cloud Storage

            var request = new ModifyEmfRequest(fileName, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, folder, storage, format);
            Stream updatedImage = this.ImagingApi.ModifyEmf(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SampleEMF_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        //  Process existing EMF image using given parameters, and upload updated image to Cloud Storage.
        public void ModifyEmfAndUploadToStorage()
        {
            string fileName = "Sample.emf";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            string format = "png";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // As we are using default Cloud Storage

            var request = new ModifyEmfRequest(fileName, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, folder, storage, format);
            using (Stream updatedImage = this.ImagingApi.ModifyEmf(request))
            {
                // Upload updated image to Cloud Storage
                string outPath = "SampleEMF_out." + format;
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Rasterize EMF image to PNG using given parameters. 
        // Image data is passed in a request stream.
        public void CreateModifiedEmfFromRequestBody()
        {
            string fileName = "Sample.emf";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                string bkColor = "gray";
                int pageWidth = 300;
                int pageHeigth = 300;
                int borderX = 50;
                int borderY = 50;
                string format = "png";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // As we are using default Cloud Storage

                var request = new CreateModifiedEmfRequest(inputImageStream, bkColor, pageWidth, pageHeigth,
                                                        borderX, borderY, fromScratch, outPath, storage, format);
                Stream updatedImage = this.ImagingApi.CreateModifiedEmf(request);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SampleEMF_out." + format))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
