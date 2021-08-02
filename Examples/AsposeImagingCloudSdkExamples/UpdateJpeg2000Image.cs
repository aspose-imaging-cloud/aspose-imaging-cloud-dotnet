// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateJPEG2000Image.cs">
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
    ///     Update JPEG2000 image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class UpdateJpeg2000Image : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateJpeg2000Image" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateJpeg2000Image(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update JPEG2000 image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "UpdateJPEG2000SampleImage.jp2";

        // Update parameters of existing JPEG2000 image. The image is saved in the cloud.
        public void ModifyJpeg2000FromStorage()
        {
            Console.WriteLine("Update parameters of a Jpeg2000 image from cloud storage");

            UploadSampleImageToCloud();

            var codec = "jp2";
            var comment = "Aspose";
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageJpeg2000Request =
                new ModifyJpeg2000Request(SampleImageFileName, comment, codec, fromScratch, folder, storage);

            Console.WriteLine($"Call ModifyJpeg2000 with params: codec:{codec}, comment:{comment}");

            using (var updatedImage = ImagingApi.ModifyJpeg2000(getImageJpeg2000Request))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of existing JPEG2000 image, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyJpeg2000AndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a Jpeg2000 image and upload to cloud storage");

            UploadSampleImageToCloud();

            var codec = "jp2";
            var comment = "Aspose";
            bool? fromScratch = null;
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImageJpeg2000Request =
                new ModifyJpeg2000Request(SampleImageFileName, comment, codec, fromScratch, folder, storage);

            Console.WriteLine($"Call ModifyJpeg2000 with params: codec:{codec}, comment:{comment}");

            using (var updatedImage = ImagingApi.ModifyJpeg2000(getImageJpeg2000Request))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName());
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Update parameters of existing JPEG2000 image. Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedJpeg2000FromRequestBody()
        {
            Console.WriteLine("Update parameters of a Jpeg2000 image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                var codec = "jp2";
                var comment = "Aspose";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                var postImageJpeg2000Request =
                    new CreateModifiedJpeg2000Request(inputImageStream, comment, codec, fromScratch, outPath, storage);

                Console.WriteLine($"Call CreateModifiedJpeg2000 with params: codec:{codec}, comment:{comment}");

                using (var updatedImage = ImagingApi.CreateModifiedJpeg2000(postImageJpeg2000Request))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}