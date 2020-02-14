// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImageProperties.cs">
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
    ///     Image properties example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class ImageProperties : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ImageProperties" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public ImageProperties(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Image properties example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        protected override string SampleImageFileName => "PropertiesOfSampleImage.tiff";

        /// <summary>
        ///     Get properties of an image, which is store in the cloud.
        /// </summary>
        public void GetImagePropertiesFromStorage()
        {
            Console.WriteLine("Get properties of an image in cloud storage");

            UploadSampleImageToCloud();

            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var getImagePropertiesRequest = new GetImagePropertiesRequest(
                SampleImageFileName, folder, storage);

            Console.WriteLine("Call GetImageProperties");

            var imagingResponse = ImagingApi.GetImageProperties(getImagePropertiesRequest);

            OutputPropertiesToFile("ImageProperties.txt", imagingResponse);

            Console.WriteLine();
        }

        /// <summary>
        ///     Get properties of an image. Image data is passed in a request stream.
        /// </summary>
        public void ExtractImagePropertiesFromRequestBody()
        {
            Console.WriteLine("Get properties of an image from request body");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                var imagePropertiesRequest = new ExtractImagePropertiesRequest(inputImageStream);

                Console.WriteLine("Call ExtractImageProperties");

                var imagingResponse = ImagingApi.ExtractImageProperties(imagePropertiesRequest);
                OutputPropertiesToFile("ImagePropertiesFromRequest.txt", imagingResponse);
            }

            Console.WriteLine();
        }
    }
}