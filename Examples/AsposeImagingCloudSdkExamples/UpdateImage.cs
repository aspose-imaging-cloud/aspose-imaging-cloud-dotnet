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

using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples
{
    /// <summary>
    ///     Update image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdateImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        /// <remarks>
        ///     Input formats could be one of the following:
        ///     BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
        /// </remarks>
        protected override string SampleImageFileName => "UpdateSampleImage.gif";

        /// <summary>
        ///     Perform scaling, cropping and flipping of an existing image in a single request. The image is saved in the cloud.
        /// </summary>
        public void UpdateImageFromStorage()
        {
            Console.WriteLine("Update parameters of an image from cloud storage");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Update 
            // for possible output formats
            var format = "pdf";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            var rotateFlipMethod = "Rotate90FlipX";
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageUpdateRequest = new UpdateImageRequest(SampleImageFileName, newWidth, newHeight, x, y,
                rectWidth, rectHeight, rotateFlipMethod, format, folder, storage);

            Console.WriteLine(
                $"Call UpdateImage with params: new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, format:{format}");

            using (var updatedImage = ImagingApi.UpdateImage(getImageUpdateRequest))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Perform scaling, cropping and flipping of an existing image in a single request. And upload updated image to Cloud
        ///     Storage.
        /// </summary>
        public void UpdateImageAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of an image and upload to cloud storage");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Update 
            // for possible output formats
            var format = "pdf";
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            var rotateFlipMethod = "Rotate90FlipX";
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageUpdateRequest = new UpdateImageRequest(SampleImageFileName, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, format, folder, storage);

            Console.WriteLine(
                $"Call UpdateImage with params: new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, format:{format}");

            using (var updatedImage = ImagingApi.UpdateImage(getImageUpdateRequest))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName());
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Perform scaling, cropping and flipping of an image in a single request. Image data is passed in a request stream.
        /// </summary>
        public void CreateUpdatedImageFromRequestBody()
        {
            Console.WriteLine("Update parameters of an image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Update 
                // for possible output formats
                var format = "pdf";
                int? newWidth = 300;
                int? newHeight = 450;
                int? x = 10;
                int? y = 10;
                int? rectWidth = 200;
                int? rectHeight = 300;
                var rotateFlipMethod = "Rotate90FlipX";
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                var postImageUpdateRequest = new CreateUpdatedImageRequest(inputImageStream, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, format, outPath, storage);

                Console.WriteLine(
                    $"Call CreateUpdatedImage with params: new width:{newWidth}, new height:{newHeight}, x:{x}, y:{y}, rect width:{rectWidth}, rectHeight:{rectHeight}, rotate/flip method:{rotateFlipMethod}, format:{format}");

                using (var updatedImage = ImagingApi.CreateUpdatedImage(postImageUpdateRequest))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}