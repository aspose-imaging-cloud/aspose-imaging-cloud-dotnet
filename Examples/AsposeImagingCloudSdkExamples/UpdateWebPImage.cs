// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WEBPImage.cs">
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
    ///     WEBP image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdateWebPImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateWebPImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateWebPImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update WEBP image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "WEBPSampleImage.webp";

        /// <summary>
        ///     Update parameters of existing WEBP image. The image is saved in the cloud.
        /// </summary>
        public void ModifyWebPFromStorage()
        {
            Console.WriteLine("Update parameters of a WEBP image from cloud storage");

            UploadSampleImageToCloud();

            bool? lossless = true;
            int? quality = 90;
            int? animLoopCount = 5;
            var animBackgroundColor = "gray";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageWebPRequest = new ModifyWebPRequest(SampleImageFileName, lossless, quality,
                animLoopCount, animBackgroundColor, fromScratch, folder, storage);

            Console.WriteLine(
                $"Call ModifyWebP with params: lossless:{lossless}, quality:{quality}, anim loop count:{animLoopCount}, anim background color:{animBackgroundColor}");

            using (var updatedImage = ImagingApi.ModifyWebP(getImageWebPRequest))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of existing WEBP image, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyWebPAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a WEBP image and upload to cloud storage");

            UploadSampleImageToCloud();

            bool? lossless = true;
            int? quality = 90;
            int? animLoopCount = 5;
            var animBackgroundColor = "gray";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageWebPRequest = new ModifyWebPRequest(SampleImageFileName, lossless, quality,
                animLoopCount, animBackgroundColor, fromScratch, folder, storage);

            Console.WriteLine(
                $"Call ModifyWebP with params: lossless:{lossless}, quality:{quality}, anim loop count:{animLoopCount}, anim background color:{animBackgroundColor}");

            using (var updatedImage = ImagingApi.ModifyWebP(getImageWebPRequest))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(), updatedImage);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of existing Webp image. asposelogo.webpImage data is passed in a request stream.
        /// </summary>
        public void CreateModifiedWebPFromRequestBody()
        {
            Console.WriteLine("Update parameters of a WEBP image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                bool? lossless = true;
                int? quality = 90;
                int? animLoopCount = 5;
                var animBackgroundColor = "gray";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                var modifiedImageWebPRequest = new CreateModifiedWebPRequest(inputImageStream, lossless, quality,
                    animLoopCount, animBackgroundColor, fromScratch, outPath, storage);

                Console.WriteLine(
                    $"Call CreateModifiedWebP with params: lossless:{lossless}, quality:{quality}, anim loop count:{animLoopCount}, anim background color:{animBackgroundColor}");

                using (var updatedImage = ImagingApi.CreateModifiedWebP(modifiedImageWebPRequest))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}