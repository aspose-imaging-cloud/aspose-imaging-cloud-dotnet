// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SearchImages.cs">
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
using System.Web;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples.AI
{
    /// <summary>
    ///     Search images.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.AI.ImagingAiBase" />
    internal class SearchImages : ImagingAiBase
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchImages" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public SearchImages(ImagingApi imagingApi) : base(imagingApi)
        {
            Console.WriteLine("Search images example:");
            Console.WriteLine();
        }

        /// <summary>
        ///     Prepares the search context.
        /// </summary>
        public void PrepareSearchContext()
        {
            CreateSearchContext();
        }

        /// <summary>
        ///     Searches for images from a web source
        /// </summary>
        public void SearchImageFromWebSource()
        {
            Console.WriteLine("Searches for images from a web source:");

            var folder = CloudPath; // Path to input files
            string storage = null; // We are using default Cloud Storage

            var imagesSourceUrl = HttpUtility.UrlEncode("https://www.f1news.ru/interview/hamilton/140909.shtml");

            ImagingApi.CreateWebSiteImageFeatures(
                new CreateWebSiteImageFeaturesRequest(SearchContextId, imagesSourceUrl, folder, storage));

            WaitIdle(SearchContextId);

            var imageUrl = HttpUtility.UrlEncode("https://cdn.f1ne.ws/userfiles/hamilton/140909.jpg");
            var response = ImagingApi.GetImageFeatures(
                new GetImageFeaturesRequest(SearchContextId, imageUrl, folder, storage));

            Console.WriteLine("Image features found: " + response.FeaturesCount);
        }
    }
}