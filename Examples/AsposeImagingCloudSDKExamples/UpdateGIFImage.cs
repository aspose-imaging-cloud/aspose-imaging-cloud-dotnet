// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateGIFImage.cs">
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

using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    /// <summary>
    /// Update GIF image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingBase" />
    class UpdateGIFImage : ImagingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGIFImage"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateGIFImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update GIF image example:");
        }

        /// <summary>
        /// Gets the name of the example image file.
        /// </summary>
        /// <value>
        /// The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "UpdateGIFSampleImage.gif";

        /// <summary>
        /// Update parameters of existing GIF image. The image is saved in the cloud.
        /// </summary>
        public void ModifyGifFromStorage()
        {
            Console.WriteLine("Update parameters of a GIF image from cloud storage");

            UploadSampleImageToCloud();

            int? backgroundColorIndex = 5;
            int? colorResolution = 4;
            bool? hasTrailer = true;
            bool? interlaced = false;
            bool? isPaletteSorted = true;
            int? pixelAspectRatio = 4;
            bool? fromScratch = null;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            ModifyGifRequest getImageGifRequest = new ModifyGifRequest(SampleImageFileName, backgroundColorIndex,
                                                            colorResolution, hasTrailer, interlaced, isPaletteSorted,
                                                            pixelAspectRatio, fromScratch, folder, storage);

            Console.WriteLine($"Call ModifyGif with params: background color index:{backgroundColorIndex}, color resolution:{colorResolution}, has trailer:{hasTrailer}, interlaced:{interlaced}, is palette sorted:{isPaletteSorted}, pixel aspect ratio:{pixelAspectRatio}");

            using (Stream updatedImage = this.ImagingApi.ModifyGif(getImageGifRequest))
            {
                SaveUpdatedImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Update parameters of existing GIF image. The image is saved in the cloud.
        /// </summary>
        public void ModifyGifAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a GIF image and upload to cloud storage");

            UploadSampleImageToCloud();

            int? backgroundColorIndex = 5;
            int? colorResolution = 4;
            bool? hasTrailer = true;
            bool? interlaced = false;
            bool? isPaletteSorted = true;
            int? pixelAspectRatio = 4;
            bool? fromScratch = null;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            ModifyGifRequest getImageGifRequest = new ModifyGifRequest(SampleImageFileName, backgroundColorIndex,
                                                            colorResolution, hasTrailer, interlaced, isPaletteSorted,
                                                            pixelAspectRatio, fromScratch, folder, storage);

            Console.WriteLine($"Call ModifyGif with params: background color index:{backgroundColorIndex}, color resolution:{colorResolution}, has trailer:{hasTrailer}, interlaced:{interlaced}, is palette sorted:{isPaletteSorted}, pixel aspect ratio:{pixelAspectRatio}");

            using (Stream updatedImage = this.ImagingApi.ModifyGif(getImageGifRequest))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(false), updatedImage);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Update parameters of GIF image. Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedGifFromRequestBody()
        {
            Console.WriteLine("Update parameters of a GIF image from request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? backgroundColorIndex = 5;
                int? colorResolution = 4;
                bool? hasTrailer = true;
                bool? interlaced = false;
                bool? isPaletteSorted = true;
                int? pixelAspectRatio = 4;
                bool? fromScratch = null;
                string outPath = null;
                string storage = null; // We are using default Cloud Storage

                CreateModifiedGifRequest postImageGifRequest = new CreateModifiedGifRequest(inputImageStream, backgroundColorIndex,
                                                colorResolution, hasTrailer, interlaced, isPaletteSorted, pixelAspectRatio,
                                                                                            fromScratch, outPath, storage);

                Console.WriteLine($"Call CreateModifiedGif with params: background color index:{backgroundColorIndex}, color resolution:{colorResolution}, has trailer:{hasTrailer}, interlaced:{interlaced}, is palette sorted:{isPaletteSorted}, pixel aspect ratio:{pixelAspectRatio}");

                using (Stream updatedImage = this.ImagingApi.CreateModifiedGif(postImageGifRequest))
                {
                    SaveUpdatedImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}