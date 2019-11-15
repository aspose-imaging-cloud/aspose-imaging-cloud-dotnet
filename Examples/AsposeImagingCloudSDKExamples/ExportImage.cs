// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExportImage.cs">
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
    /// Export image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingBase" />
    class ExportImage : ImagingBase
    {
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
        protected override string SampleImageFileName => "ExportSampleImage.bmp";

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportImage"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public ExportImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Export image example:");
        }

        /// <summary>
        /// Export an image to another format.
        /// </summary>
        public void SaveImageAsFromStorage()
        {
            Console.WriteLine("Export an image to another format");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Export(SaveAs) 
            // for possible output formats
            string format = "pdf";
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // Cloud Storage name
            
            var request = new SaveImageAsRequest(SampleImageFileName, format, folder, storage);

            Console.WriteLine($"Call SaveImageAs with params: format:{format}");

            using (Stream updatedImage = this.ImagingApi.SaveImageAs(request))
            {
                SaveUpdatedImageToOutput(updatedImage, false, format);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Export an image to another format.
        /// </summary>
        public void SaveImageAsAndUploadToStorage()
        {
            Console.WriteLine("Export an image to another format and upload to cloud storage");

            UploadSampleImageToCloud();

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Export(SaveAs)
            // for possible output formats
            string format = "pdf";
            string folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // Cloud Storage name

            var request = new SaveImageAsRequest(SampleImageFileName, format, folder, storage);

            Console.WriteLine($"Call SaveImageAs with params: format:{format}");

            using (Stream updatedImage = this.ImagingApi.SaveImageAs(request))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(false, format), updatedImage);              
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Export an image to another format. Image data is passed in a request stream.
        /// </summary>
        public void CreateSavedImageAsFromRequestBody()
        {
            Console.WriteLine("Export an image to another format. Image data is passed in a request body");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-Export(SaveAs)
                // for possible output formats
                string format = "pdf";
                string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
                string storage = null; // Cloud Storage name

                var request = new CreateSavedImageAsRequest(inputImageStream, format, outPath, storage);

                Console.WriteLine($"Call CreateSavedImageAs with params: format:{format}");

                using (Stream updatedImage = this.ImagingApi.CreateSavedImageAs(request))
                {
                    SaveUpdatedImageToOutput(updatedImage, true, format);
                }

                Console.WriteLine();
            }
        }
    }
}