// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateJPEG2000Image.cs">
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
    class UpdateJPEG2000Image : ImagingBase
    {
        // Update parameters of existing JPEG2000 image. The image is saved in the cloud.
        public void ModifyJpeg2000FromStorage()
        {
            string fileName = "Sample.jp2";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            ModifyJpeg2000Request getImageJpeg2000Request = new ModifyJpeg2000Request(fileName, comment, codec,
                                                                                fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyJpeg2000(getImageJpeg2000Request);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jp2"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of existing JPEG2000 image, and upload updated image to Cloud Storage
        public void ModifyJpeg2000AndUploadToStorage()
        {
            string fileName = "Sample.jp2";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            ModifyJpeg2000Request getImageJpeg2000Request = new ModifyJpeg2000Request(fileName, comment, codec,
                                                                                fromScratch, folder, storage);

            using (Stream updatedImage = this.ImagingApi.ModifyJpeg2000(getImageJpeg2000Request))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Sample_out.jp2";
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Update parameters of existing JPEG2000 image. Image data is passed in a request stream.
        public void CreateModifiedJpeg2000FromRequestBody()
        {
            string fileName = "Sample.jp2";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                string codec = "jp2";
                string comment = "Aspose";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                CreateModifiedJpeg2000Request postImageJpeg2000Request = new CreateModifiedJpeg2000Request(inputImageStream, comment, codec,
                                                                                            fromScratch, outPath, storage);

                Stream updatedImage = this.ImagingApi.CreateModifiedJpeg2000(postImageJpeg2000Request);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jp2"))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
