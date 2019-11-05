// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExportImage.cs">
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
    class ExportImage : ImagingBase
    {
        // Export an image to another format.
        public void SaveImageAsFromStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Export(SaveAs) 
            // for possible output formats
            string format = "pdf";
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // Cloud Storage name
            
            var request = new SaveImageAsRequest(fileName, format, folder, storage);
            Stream updatedImage = this.ImagingApi.SaveImageAs(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Export an image to another format.
        public void SaveImageAsAndUploadToStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Export(SaveAs)
            // for possible output formats
            string format = "pdf";
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // Cloud Storage name

            var request = new SaveImageAsRequest(fileName, format, folder, storage);
            using (Stream updatedImage = this.ImagingApi.SaveImageAs(request))
            {
                // Upload updated image to Cloud Storage
                string outPath = "Watermark_out." + format;
                var uploadFileRequest = new UploadFileRequest(outPath, updatedImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
        }

        // Export an image to another format. Image data is passed in a request stream.
        public void CreateSavedImageAsFromRequestBody()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "WaterMark.bmp";
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Export(SaveAs)
                // for possible output formats
                string format = "pdf";
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // Cloud Storage name

                var request = new CreateSavedImageAsRequest(inputImageStream, format, outPath, storage);
                Stream updatedImage = this.ImagingApi.CreateSavedImageAs(request);

                // Save updated image to local storage
                using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out." + format))
                {
                    updatedImage.Seek(0, SeekOrigin.Begin);
                    updatedImage.CopyTo(fileStream);
                }
            }
        }
    }
}
