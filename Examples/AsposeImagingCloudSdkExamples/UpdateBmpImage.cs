// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateBMPImage.cs">
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
    ///     Update BMP image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdateBmpImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateBmpImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateBmpImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update BMP image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "UpdateBmpSampleImage.bmp";

        /// <summary>
        ///     Update parameters of a BMP image.
        ///     The image is saved in the cloud.
        /// </summary>
        public void ModifyBmpFromStorage()
        {
            Console.WriteLine("Update parameters of a BMP image from cloud storage");

            // Upload local image to Cloud Storage
            UploadSampleImageToCloud();

            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new ModifyBmpRequest(
                SampleImageFileName, bitsPerPixel, horizontalResolution, verticalResolution,
                fromScratch, folder, storage);

            Console.WriteLine(
                $"Call ModifyBmp with params: bits per pixel:{bitsPerPixel}, horizontal resolution:{horizontalResolution}, vertical resolution:{verticalResolution}");

            using (var updatedImage = ImagingApi.ModifyBmp(request))
            {
                // Save updated image to local storage
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        // Update parameters of a BMP image, and upload updated image to Cloud Storage.
        public void ModifyBmpAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a BMP image and upload to cloud storage");

            // Upload local image to Cloud Storage
            UploadSampleImageToCloud();

            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new ModifyBmpRequest(
                SampleImageFileName, bitsPerPixel, horizontalResolution, verticalResolution,
                fromScratch, folder, storage);

            Console.WriteLine(
                $"Call ModifyBmp with params: bits per pixel:{bitsPerPixel}, horizontal resolution:{horizontalResolution}, vertical resolution:{verticalResolution}");

            using (var updatedImage = ImagingApi.ModifyBmp(request))
            {
                // Upload updated image to Cloud Storage
                UploadImageToCloud(GetModifiedSampleImageFileName(), updatedImage);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of a BMP image. Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedBmpFromRequestBody()
        {
            Console.WriteLine("Update parameters of a BMP image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? bitsPerPixel = 32;
                int? horizontalResolution = 300;
                int? verticalResolution = 300;
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                var request = new CreateModifiedBmpRequest(inputImageStream, bitsPerPixel, horizontalResolution,
                    verticalResolution, fromScratch, outPath, storage);

                Console.WriteLine(
                    $"Call CreateModifiedBmp with params: bits per pixel:{bitsPerPixel}, horizontal resolution:{horizontalResolution}, vertical resolution:{verticalResolution}");

                using (var updatedImage = ImagingApi.CreateModifiedBmp(request))
                {
                    // Save updated image to local storage
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}