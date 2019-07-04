// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateImage.cs">
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
    class UpdateImage : ImagingBase
    {
        // Perform scaling, cropping and flipping of an existing image in a single request. 
        // The image is saved in the cloud.
        public void UpdateImageFromStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "Sample.gif";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Update 
            // for possible output formats
            string format = "pdf";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            UpdateImageRequest getImageUpdateRequest = new UpdateImageRequest(fileName, format, newWidth,
                                newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, folder, storage);

            Stream updatedImage = this.ImagingApi.UpdateImage(getImageUpdateRequest); ;
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Perform scaling, cropping and flipping of an existing image in a single request. 
        // And upload updated image to Cloud Storage
        public void UpdateImageAndUploadToStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "Sample.gif";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Update 
            // for possible output formats
            string format = "pdf";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            UpdateImageRequest getImageUpdateRequest = new UpdateImageRequest(fileName, format, newWidth,
                                newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, folder, storage);

            using (Stream updatedImage = this.ImagingApi.UpdateImage(getImageUpdateRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Sample_out." + format;
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Perform scaling, cropping and flipping of an image in a single request.
        // Image data is passed in a request stream.
        public void CreateUpdatedImageFromRequestBody()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "Sample.gif";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Update 
                // for possible output formats
                string format = "pdf";
                int? newWidth = 300;
                int? newHeight = 450;
                int? x = 10;
                int? y = 10;
                int? rectWidth = 200;
                int? rectHeight = 300;
                string rotateFlipMethod = "Rotate90FlipX";
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                CreateUpdatedImageRequest postImageUpdateRequest = new CreateUpdatedImageRequest(inputImageStream, format, newWidth,
                                            newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, outPath, storage);

                Stream updatedImage = this.ImagingApi.CreateUpdatedImage(postImageUpdateRequest);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
