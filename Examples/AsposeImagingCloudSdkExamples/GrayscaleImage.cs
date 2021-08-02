// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GrayscaleImage.cs">
//   Copyright (c) 2018-2020 Aspose Pty Ltd. All rights reserved.
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
    /// Grayscale image example.
    /// </summary>
    /// <seealso cref="ImagingBase" />
    class GrayscaleImage : ImagingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrayscaleImage"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public GrayscaleImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Grayscale image example:");
        }

        /// <summary>
        /// Gets the name of the example image file.
        /// </summary>
        /// <value>
        /// The name of the example image file.
        /// </value>
        /// <remarks>
        /// Input formats could be one of the following:
        /// BMP, GIF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG
        /// </remarks>
        protected override string SampleImageFileName => "GrayscaleSampleImage.bmp";

        private const string SaveImageFormat = "bmp";

        /// <summary>
        /// Grayscales an image from a cloud storage.
        /// </summary>
        public void GrayscaleImageFromStorage()
        {
            Console.WriteLine("Grayscale the image from cloud storage");

            UploadSampleImageToCloud();

            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new GrayscaleImageRequest(SampleImageFileName, folder, storage);

            Console.WriteLine($"Call Grayscale Image");

            using (Stream updatedImage = this.ImagingApi.GrayscaleImage(request))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false, SaveImageFormat);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Grayscale an existing image, and upload updated image to a cloud storage.
        /// </summary>
        public void GrayscaleImageAndUploadToStorage()
        {
            Console.WriteLine("Grayscales the image and upload to cloud storage");

            UploadSampleImageToCloud();

            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new GrayscaleImageRequest(SampleImageFileName, folder, storage);

            Console.WriteLine($"Call Grayscale Image");

            using (Stream updatedImage = this.ImagingApi.GrayscaleImage(request))
            {
                UploadImageToCloudExample(updatedImage, GetModifiedSampleImageFileName(false, SaveImageFormat));
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Grayscales an image. Image data is passed in a request stream.
        /// </summary>
        public void CreateGrayscaledImageFromRequestBody()
        {
            Console.WriteLine("Grayscales the image from request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                string storage = null; // We are using default Cloud Storage
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)

                var request = new CreateGrayscaledImageRequest(inputImageStream, outPath, storage);

                Console.WriteLine($"Call CreateGrayscale Image");

                using (Stream updatedImage = this.ImagingApi.CreateGrayscaledImage(request))
                {
                    SaveUpdatedSampleImageToOutput(updatedImage, true, SaveImageFormat);
                }
            }

            Console.WriteLine();
        }
    }
}