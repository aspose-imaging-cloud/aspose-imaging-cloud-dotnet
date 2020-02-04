// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CropImage.cs">
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
    /// Crop image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingBase" />
    class CropImage : ImagingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CropImage"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public CropImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Crop image example:");
        }

        /// <summary>
        /// Gets the name of the example image file.
        /// </summary>
        /// <value>
        /// The name of the example image file.
        /// </value>
        /// <remarks>
        /// Input formats could be one of the following:
        /// BMP, GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
        /// </remarks>
        protected override string SampleImageFileName => "CropSampleImage.bmp";

        /// <summary>
        /// Crops the image from cloud storage.
        /// </summary>
        public void CropImageFromStorage()
        {
            Console.WriteLine("Crops the image from cloud storage");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Crop 
            // for possible output formats
            string format = "jpg"; // Resulting image format.
            int? x = 10;
            int? y = 10;
            int? width = 100;
            int? height = 150;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new CropImageRequest(SampleImageFileName, x, y, width, height, format, folder, storage);

            Console.WriteLine($"Call CropImage with params:x:{x},y:{y}, width:{width}, height:{height}");

            using (Stream updatedImage = this.ImagingApi.CropImage(request))
            {
                SaveUpdatedImageToOutput(updatedImage, false, format);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Crop an existing image, and upload updated image to Cloud Storage.
        /// </summary>
        public void CropImageAndUploadToStorage()
        {
            Console.WriteLine("Crops the image and upload to cloud storage");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Crop 
            // for possible output formats
            string format = "jpg"; // Resulting image format.
            int? x = 10;
            int? y = 10;
            int? width = 100;
            int? height = 150;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var request = new CropImageRequest(SampleImageFileName, x, y, width, height, format, folder, storage);

            Console.WriteLine($"Call CropImage with params:x:{x},y:{y}, width:{width}, height:{height}");

            using (Stream updatedImage = this.ImagingApi.CropImage(request))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(false, format), updatedImage);               
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Crop an image. Image data is passed in a request stream.
        /// </summary>
        public void CreateCroppedImageFromRequestBody()
        {
            Console.WriteLine("Crops the image from request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Crop 
                // for possible output formats
                string format = "jpg"; // Resulting image format.
                int? x = 10;
                int? y = 10;
                int? width = 100;
                int? height = 150;
                string storage = null; // We are using default Cloud Storage
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)

                var request = new CreateCroppedImageRequest(inputImageStream, x, y, width, height, format, outPath, storage);

                Console.WriteLine($"Call CreateCroppedImage with params:x:{x},y:{y}, width:{width}, height:{height}");

                using (Stream updatedImage = this.ImagingApi.CreateCroppedImage(request))
                {
                    SaveUpdatedImageToOutput(updatedImage, true, format);
                }              
            }

            Console.WriteLine();
        }
    }
}