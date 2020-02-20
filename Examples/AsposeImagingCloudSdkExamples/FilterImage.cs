// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FilterImage.cs">
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
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples
{
    /// <summary>
    ///     Apply a filtering effect to an image example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.ImagingBase" />
    internal class FilterImage : ImagingBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FilterImage" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public FilterImage(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Filter image example:");
        }

        /// <summary>
        ///     Gets the name of the example image file.
        /// </summary>
        /// <value>
        ///     The name of the example image file.
        /// </value>
        /// <remarks>
        ///     Input formats could be one of the following:
        ///     PDF, DJVU, GIF, TIFF and WEBP
        /// </remarks>
        protected override string SampleImageFileName => "FilterEffectSampleImage.psd";

        /// <summary>
        ///     Applies filtering effect to an image from cloud storage.
        /// </summary>
        public void FilterImageFromStorage()
        {
            Console.WriteLine("Apply filtering effect to an image from cloud storage");

            UploadSampleImageToCloud();

            var filterType = "BigRectangular";
            var filterProperties = new BigRectangularFilterProperties();
            var format = "gif";
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var filterEffectRequest = new FilterEffectImageRequest(SampleImageFileName, filterType, filterProperties,
                format, folder, storage);

            Console.WriteLine(
                $"Call FilterEffectImage with params: filter type:{filterType}, format:{format}");

            using (var updatedImage = ImagingApi.FilterEffectImage(filterEffectRequest))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, false, format);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Applies filtering effect to an image and upload updated image to Cloud Storage.
        /// </summary>
        public void FilterImageAndUploadToStorage()
        {
            Console.WriteLine("Apply filtering effect to an image and upload to cloud storage");

            UploadSampleImageToCloud();

            var filterType = "BigRectangular";
            var filterProperties = new BigRectangularFilterProperties();
            var format = "gif";
            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // We are using default Cloud Storage

            var filterEffectRequest = new FilterEffectImageRequest(SampleImageFileName, filterType, filterProperties,
                format, folder, storage);

            Console.WriteLine(
                $"Call FilterEffectImage with params: filter type:{filterType}, format:{format}");

            using (var updatedImage = ImagingApi.FilterEffectImage(filterEffectRequest))
            {
                UploadImageToCloud(GetModifiedSampleImageFileName(false, format), updatedImage);
            }

            Console.WriteLine();
        }
    }
}