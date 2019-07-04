// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RotateFlipAnImage.cs">
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
    class RotateFlipImage : ImagingBase
    {
        // Rotate and/or flip an image.
        public void RotateFlipImageFromStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "Sample.psd";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-RotateFlip 
            // for possible output formats
            string format = "gif";
            string method = "Rotate90FlipX"; // RotateFlip method
            string folder = null; // Folder with image to process.
            string storage = null; // We are using default Cloud Storage

            RotateFlipImageRequest getImageRotateFlipRequest = new RotateFlipImageRequest(fileName, format,
                                                                                method, folder, storage);

            Stream updatedImage = this.ImagingApi.RotateFlipImage(getImageRotateFlipRequest);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Rotate and/or flip an image, and upload updated image to Cloud Storage
        public void RotateFlipImageAndUploadToStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "Sample.psd";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-RotateFlip 
            // for possible output formats
            string format = "gif";
            string method = "Rotate90FlipX"; // RotateFlip method
            string folder = null; // Folder with image to process.
            string storage = null; // We are using default Cloud Storage

            RotateFlipImageRequest getImageRotateFlipRequest = new RotateFlipImageRequest(fileName, format,
                                                                                method, folder, storage);

            using (Stream updatedImage = this.ImagingApi.RotateFlipImage(getImageRotateFlipRequest))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Sample_out." + format;
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Rotate and/or flip an image.
        // Image data is passed in a request stream.
        public void CreateRotateFlippedImageFromRequestBody()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "Sample.psd";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-RotateFlip 
                // for possible output formats
                String format = "gif";
                String method = "Rotate90FlipX"; // RotateFlip method
                String outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                String storage = null; // We are using default Cloud Storage

                CreateRotateFlippedImageRequest createRotateFlippedImageRequest = new CreateRotateFlippedImageRequest(inputImageStream, format,
                                                                                                method, outPath, storage);

                Stream updatedImage = this.ImagingApi.CreateRotateFlippedImage(createRotateFlippedImageRequest);

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
