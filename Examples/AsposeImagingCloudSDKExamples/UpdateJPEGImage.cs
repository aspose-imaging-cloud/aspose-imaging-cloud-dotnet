// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateJPEGImage.cs">
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
    /// Update JPEG image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingBase" />
    class UpdateJPEGImage : ImagingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateJPEGImage"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public UpdateJPEGImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Update JPEG image example:");
        }

        /// <summary>
        /// Gets the name of the example image file.
        /// </summary>
        /// <value>
        /// The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "UpdateJPEGSampleImage.jpg";

        /// <summary>
        /// Update parameters of existing JPEG image. The image is saved in the cloud.
        /// </summary>
        public void ModifyJpegFromStorage()
        {
            Console.WriteLine("Update parameters of a JPEG image from cloud storage");

            UploadSampleImageToCloud();
            
            int? quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            ModifyJpegRequest modifyJpegRequest = new ModifyJpegRequest(SampleImageFileName, quality, compressionType,
                                                                                fromScratch, folder, storage);

            Console.WriteLine($"Call ModifyJpeg with params: quality:{quality}, compression type:{compressionType}");

            using (Stream updatedImage = this.ImagingApi.ModifyJpeg(modifyJpegRequest))
            {
                SaveUpdatedImageToOutput(updatedImage, false);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Update parameters of existing JPEG image, and upload updated image to Cloud Storage.
        /// </summary>
        public void ModifyJpegAndUploadToStorage()
        {
            Console.WriteLine("Update parameters of a JPEG image and upload to cloud storage");

            UploadSampleImageToCloud();

            int? quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            ModifyJpegRequest modifyJpegRequest = 
                new ModifyJpegRequest(SampleImageFileName, quality, compressionType, fromScratch, folder, storage);

            Console.WriteLine($"Call ModifyJpeg with params: quality:{quality}, compression type:{compressionType}");

            using (Stream updatedImage = this.ImagingApi.ModifyJpeg(modifyJpegRequest))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(false), updatedImage);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Update parameters of existing JPEG image. Image data is passed in a request stream.
        /// </summary>
        public void CreateModifiedJpegFromRequestBody()
        {
            Console.WriteLine("Update parameters of a JPEG image from request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                int? quality = 65;
                string compressionType = "progressive";
                bool? fromScratch = null;
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // We are using default Cloud Storage

                CreateModifiedJpegRequest modifiedJpgRequest =
                    new CreateModifiedJpegRequest(inputImageStream, quality, compressionType, fromScratch, outPath, storage);

                Console.WriteLine($"Call CreateModifiedJpeg with params: quality:{quality}, compression type:{compressionType}");

                using (Stream updatedImage = this.ImagingApi.CreateModifiedJpeg(modifiedJpgRequest))
                {
                    SaveUpdatedImageToOutput(updatedImage, true);
                }
            }

            Console.WriteLine();
        }
    }
}