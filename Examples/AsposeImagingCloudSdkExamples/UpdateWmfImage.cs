// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WMFImage.cs">
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
    ///     WMF image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdateWmfImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateWmfImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateWmfImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update WMF image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "WMFSampleImage.wmf";

        /// <summary>
        ///     Process existing WMF image using given parameters.
        ///     The image is saved in the cloud.
        /// </summary>
        public void ModifyWmfFromStorage()
        {
            Console.WriteLine("Update parameters of a WMF image from cloud storage");

            UploadSampleImageToCloud();

            var bkColor = "gray";
            int? pageWidth = 300;
            int? pageHeight = 300;
            int? borderX = 50;
            int? borderY = 50;
            bool? fromScratch = null;
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage

            string storage = null; // We are using default Cloud Storage
            var exportFormat = "png";

            var getImageWmfRequest =
                new ModifyWmfRequest(SampleImageFileName, bkColor, pageWidth, pageHeight,
                    borderX, borderY, fromScratch, folder,
                    storage, exportFormat);

            Console.WriteLine(
                $"Call ModifyWmf with params: background color:{bkColor}, page width:{pageWidth}, page height:{pageHeight}, border X:{borderX}, border Y:{borderY}");

            using (var updatedImage = ImagingApi.ModifyWmf(getImageWmfRequest))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Process existing WMF image using given parameters, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyWmfAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a WMF image and upload to cloud storage");

            UploadSampleImageToCloud();

            var bkColor = "gray";
            int? pageWidth = 300;
            int? pageHeight = 300;
            int? borderX = 50;
            int? borderY = 50;
            bool? fromScratch = null;
            var folder = CloudImageFolder; // Input file is saved at the Examples folder in the storage

            string storage = null; // We are using default Cloud Storage
            var exportFormat = "png";

            var getImageWmfRequest =
                new ModifyWmfRequest(SampleImageFileName, bkColor, pageWidth, pageHeight,
                    borderX, borderY, fromScratch, folder,
                    storage, exportFormat);

            Console.WriteLine(
                $"Call ModifyWmf with params: background color:{bkColor}, page width:{pageWidth}, page height:{pageHeight}, border X:{borderX}, border Y:{borderY}");

            using (var updatedImage = ImagingApi.ModifyWmf(getImageWmfRequest))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName());
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Process existing WMF image using given parameters.
        ///     Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedWmfFromRequestBody()
        {
            Console.WriteLine("Update parameters of a WMF image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                var bkColor = "gray";
                int? pageWidth = 300;
                int? pageHeight = 300;
                int? borderX = 50;
                int? borderY = 50;
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
                string storage = null; // We are using default Cloud Storage
                var exportFormat = "png";

                var postImageWmfRequest =
                    new CreateModifiedWmfRequest(inputImageStream, bkColor, pageWidth,
                        pageHeight, borderX, borderY, fromScratch, outPath,
                        storage, exportFormat);

                Console.WriteLine(
                    $"Call CreateModifiedWmf with params: background color:{bkColor}, page width:{pageWidth}, page height:{pageHeight}, border X:{borderX}, border Y:{borderY}");

                using (var updatedImage = ImagingApi.CreateModifiedWmf(postImageWmfRequest))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}