// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TIFFImage.cs">
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
    ///     TIFF image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class TiffImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TiffImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public TiffImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("TIFF image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "TiffSampleImage.tiff";

        /// <summary>
        ///     Update parameters of TIFF image. The image is saved in the cloud.
        /// </summary>
        public void ModifyTiffFromStorage()
        {
            Console.WriteLine("Update parameters of a TIFF image from cloud storage");

            UploadSampleImageToCloud();

            // Update parameters of TIFF image
            var compression = "adobedeflate";
            var resolutionUnit = "inch";
            int? bitDepth = 1;
            double horizontalResolution = 150;
            double verticalResolution = 150;
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageTiffRequest =
                new ModifyTiffRequest(SampleImageFileName, bitDepth, compression, resolutionUnit,
                    horizontalResolution, verticalResolution, fromScratch, folder, storage);

            Console.WriteLine(
                $"Call ModifyTiff with params: compression:{compression}, resolution unit:{resolutionUnit}, bit depth:{bitDepth}, horizontal resolution:{horizontalResolution}, vertical resolution:{verticalResolution} ");

            using (var updatedImage = ImagingApi.ModifyTiff(getImageTiffRequest))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of TIFF image, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyTiffAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a TIFF image and upload to cloud storage");

            UploadSampleImageToCloud();

            // Update parameters of TIFF image
            var compression = "adobedeflate";
            var resolutionUnit = "inch";
            int? bitDepth = 1;
            double horizontalResolution = 150;
            double verticalResolution = 150;
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageTiffRequest =
                new ModifyTiffRequest(SampleImageFileName, bitDepth, compression, resolutionUnit,
                    horizontalResolution, verticalResolution, fromScratch, folder, storage);

            Console.WriteLine(
                $"Call ModifyTiff with params: compression:{compression}, resolution unit:{resolutionUnit}, bit depth:{bitDepth}, horizontal resolution:{horizontalResolution}, vertical resolution:{verticalResolution} ");

            using (var updatedImage = ImagingApi.ModifyTiff(getImageTiffRequest))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName());
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of TIFF image.
        ///     Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedTiffFromRequestBody()
        {
            Console.WriteLine("Update parameters of a TIFF image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                var compression = "adobedeflate";
                var resolutionUnit = "inch";
                int? bitDepth = 1;
                double horizontalResolution = 150;
                double verticalResolution = 150;
                bool? fromScratch = null;
                string outPath = null;
                string storage = null; // We are using default Cloud Storage

                var postImageTiffRequest = new CreateModifiedTiffRequest(inputImageStream, bitDepth, compression,
                    resolutionUnit, horizontalResolution, verticalResolution, fromScratch, outPath, storage);

                Console.WriteLine(
                    $"Call CreateModifiedTiff with params: compression:{compression}, esolution unit:{resolutionUnit}, bit depth:{bitDepth}, horizontal resolution:{horizontalResolution}, vertical resolution:{verticalResolution} ");

                using (var updatedImage = ImagingApi.CreateModifiedTiff(postImageTiffRequest))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of TIFF image according to fax parameters.
        /// </summary>
        public void ConvertTiffToFaxFromStorage()
        {
            Console.WriteLine("Update parameters of TIFF image according to fax parameters.");

            UploadSampleImageToCloud();

            // Update TIFF Image parameters according to fax parameters
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getTiffToFaxRequest = new ConvertTiffToFaxRequest(
                SampleImageFileName, storage, folder);

            Console.WriteLine("Call ConvertTiffToFax");

            using (var updatedImage = ImagingApi.ConvertTiffToFax(getTiffToFaxRequest))
            {
                SaveUpdatedImageToOutput("ConvertTiffToFax.tiff", updatedImage);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images).
        /// </summary>
        public void AppendTiffFromStorage()
        {
            Console.WriteLine(" Appends existing TIFF image to another existing TIFF image.");

            var appendFileName = "Append.tiff"; // Image file name to be appended to original one

            UploadSampleImageToCloud();

            // Upload file be appended to cloud storage
            using (var localInputImage = File.OpenRead(Path.Combine(ExampleImagesFolder, appendFileName)))
            {
                UploadImageToCloudExample(localInputImage, appendFileName);
            }

            // Update TIFF Image parameters according to fax parameters
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new AppendTiffRequest(SampleImageFileName, appendFileName, storage, folder);

            Console.WriteLine("Call AppendTiff");

            ImagingApi.AppendTiff(request);

            // Download updated file to local storage
            var downloadFileRequest = new DownloadFileRequest(
                Path.Combine(CloudPath, SampleImageFileName), storage);
            using (var updatedImage = ImagingApi.DownloadFile(downloadFileRequest))
            {
                SaveUpdatedImageToOutput("AppendToTiff.tiff", updatedImage);
            }

            Console.WriteLine();
        }
    }
}