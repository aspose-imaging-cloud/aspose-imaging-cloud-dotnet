// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ResizeImage.cs">
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

using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples
{
    /// <summary>
    ///     Resize image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class ResizeImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ResizeImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public ResizeImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Resize an image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        /// <remarks>
        ///     Input formats could be one of the following:
        ///     BMP, GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
        /// </remarks>
        protected override string SampleImageFileName => "ResizeSampleImage.psd";

        /// <summary>
        ///     Resizes the image.
        /// </summary>
        public void ResizeImageFromStorage()
        {
            Console.WriteLine("Resize an image from cloud storage");

            // Upload local image to Cloud Storage
            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Resize 
            // for possible output formats
            var format = "gif";
            int? newWidth = 100;
            int? newHeight = 150;
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var resizeImageRequest = new ResizeImageRequest(
                SampleImageFileName, newWidth, newHeight, format, folder, storage);

            Console.WriteLine(
                $"Call ResizeImage with params: new width:{newWidth}, new height:{newHeight}, format:{format}");

            using (var updatedImage = ImagingApi.ResizeImage(resizeImageRequest))
            {
                // Save updated image to local storage
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Resizes the sample image and upload to Cloud Storage
        /// </summary>
        public void ResizeImageAndUploadToStorage()
        {
            Console.WriteLine("Resize an image and upload to cloud storage");

            // Upload local image to Cloud Storage
            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Resize 
            // for possible output formats
            var format = "gif";
            int? newWidth = 100;
            int? newHeight = 150;
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var resizeImageRequest = new ResizeImageRequest(
                SampleImageFileName, newWidth, newHeight, format, folder, storage);

            Console.WriteLine(
                $"Call ResizeImage with params: new width:{newWidth}, new height:{newHeight}, format:{format}");

            using (var updatedImage = ImagingApi.ResizeImage(resizeImageRequest))
            {
                // Upload updated image to Cloud Storage
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName(false, format));
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Resize an image. Image data is passed in a request stream.
        /// </summary>
        public void CreateResizedImageFromRequestBody()
        {
            Console.WriteLine("Resize an image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Resize 
                // for possible output formats
                var format = "gif";
                int? newWidth = 100;
                int? newHeight = 150;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                var createResizedImageRequest = new CreateResizedImageRequest(
                    inputImageStream, newWidth, newHeight, format, outPath, storage);

                Console.WriteLine(
                    $"Call CreateResizedImage with params: new width:{newWidth}, new height:{newHeight}, format:{format}");

                using (var updatedImage = ImagingApi.CreateResizedImage(createResizedImageRequest))
                {
                    // Save updated image to local storage
                    SaveUpdatedSampleImageToOutput(updatedImage, true, format);
                }
            }

            Console.WriteLine();
        }
    }
}