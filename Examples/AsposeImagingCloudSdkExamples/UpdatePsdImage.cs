// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdatePSDImage.cs">
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
    ///     Update PSD image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdatePsdImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdatePsdImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdatePsdImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update PSD image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "UpdatePSDSampleImage.psd";

        /// <summary>
        ///     Update parameters of existing PSD image. The image is saved in the cloud.
        /// </summary>
        public void ModifyPsdFromStorage()
        {
            Console.WriteLine("Update parameters of a PSD image from cloud storage");

            UploadSampleImageToCloud();

            int? channelsCount = 3;
            var compressionMethod = "raw";
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var modifyPsdRequest =
                new ModifyPsdRequest(SampleImageFileName, channelsCount, compressionMethod, fromScratch, folder,
                    storage);

            Console.WriteLine(
                $"Call ModifyPsd with params: channels count:{channelsCount}, compression method:{compressionMethod}");

            using (var updatedImage = ImagingApi.ModifyPsd(modifyPsdRequest))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of existing PSD image, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyPsdAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a PSD image and upload to cloud storage");

            UploadSampleImageToCloud();

            int? channelsCount = 3;
            var compressionMethod = "raw";
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var modifyPsdRequest =
                new ModifyPsdRequest(SampleImageFileName, channelsCount, compressionMethod, fromScratch, folder,
                    storage);

            Console.WriteLine(
                $"Call ModifyPsd with params: channels count:{channelsCount}, compression method:{compressionMethod}");

            using (var updatedImage = ImagingApi.ModifyPsd(modifyPsdRequest))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName());
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of existing PSD image. Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedPsdFromRequestBody()
        {
            Console.WriteLine("Update parameters of a PSD image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? channelsCount = 3;
                var compressionMethod = "raw";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage

                var modifiedPsdRequest =
                    new CreateModifiedPsdRequest(inputImageStream, channelsCount,
                        compressionMethod, fromScratch, outPath, storage);

                Console.WriteLine(
                    $"Call CreateModifiedPsd with params: channels count:{channelsCount}, compression method:{compressionMethod}");

                using (var updatedImage = ImagingApi.CreateModifiedPsd(modifiedPsdRequest))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}