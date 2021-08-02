// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateEMFImageProperties.cs">
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
    ///     Update EMF image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdateEmfImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateEmfImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateEmfImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update EMF image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "UpdateEMFSampleImage.emf";

        /// <summary>
        ///     Modifies the EMF from storage.
        /// </summary>
        public void ModifyEmfFromStorage()
        {
            Console.WriteLine("Update parameters of a EMF image");

            UploadSampleImageToCloud();

            var bkColor = "gray";
            var pageWidth = 300;
            var pageHeigth = 300;
            var borderX = 50;
            var borderY = 50;
            var format = "png";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // As we are using default Cloud Storage

            var request = new ModifyEmfRequest(
                SampleImageFileName, bkColor, pageWidth, pageHeigth, borderX, borderY,
                fromScratch, folder, storage, format);

            Console.WriteLine(
                $"Call ModifyEmf with params: background color:{bkColor}, width:{pageWidth}, height:{pageHeigth}, border x:{borderX}, border y:{borderY}, format:{format}");

            using (var updatedImage = ImagingApi.ModifyEmf(request))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false, format);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Process existing EMF image using given parameters, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyEmfAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a EMF image and upload to cloud storage");

            UploadSampleImageToCloud();

            var bkColor = "gray";
            var pageWidth = 300;
            var pageHeigth = 300;
            var borderX = 50;
            var borderY = 50;
            var format = "png";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // As we are using default Cloud Storage

            var request = new ModifyEmfRequest(
                SampleImageFileName, bkColor, pageWidth, pageHeigth, borderX, borderY,
                fromScratch, folder, storage, format);

            Console.WriteLine(
                $"Call ModifyEmf with params: background color:{bkColor}, width:{pageWidth}, height:{pageHeigth}, border x:{borderX}, border y:{borderY}, format:{format}");

            using (var updatedImage = ImagingApi.ModifyEmf(request))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName(false, format));
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Rasterize EMF image to PNG using given parameters.
        ///     Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedEmfFromRequestBody()
        {
            Console.WriteLine("Update parameters of a EMF image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                var bkColor = "gray";
                var pageWidth = 300;
                var pageHeigth = 300;
                var borderX = 50;
                var borderY = 50;
                var format = "png";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // As we are using default Cloud Storage

                var request = new CreateModifiedEmfRequest(inputImageStream, bkColor, pageWidth, pageHeigth,
                    borderX, borderY, fromScratch, outPath, storage, format);

                Console.WriteLine(
                    $"Call CreateModifiedEmf with params: background color:{bkColor}, width:{pageWidth}, height:{pageHeigth}, border x:{borderX}, border y:{borderY}, format:{format}");

                using (var updatedImage = ImagingApi.CreateModifiedEmf(request))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true, format);
                }
            }

            Console.WriteLine();
        }
    }
}