// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SearchContextImages.cs">
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

using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    class SearchContextImages : ImagingAIBase
    {
        // Get image from search context
        public void GetSearchImage()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string imageId = "WaterMark.bmp";
            string folder = null;
            string storage = null;

            GetSearchImageRequest request =
                                            new GetSearchImageRequest(searchContextId, imageId, folder, storage);
            Stream retrievedImage = this.ImagingApi.GetSearchImage(request);

            // Save retrieved image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out.bmp"))
            {
                retrievedImage.Seek(0, SeekOrigin.Begin);
                retrievedImage.CopyTo(fileStream);
            }

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }


        // Add image and images features to search context.
        // Image data is passed in a request stream.
        public void AddSearchImage()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string imageId = "WaterMark.bmp";
            string folder = null;
            string storage = null;

            // Input image
            using (FileStream imageData = File.OpenRead(ImagingBase.PathToDataFiles + imageId))
            {
                AddSearchImageRequest request =
                                new AddSearchImageRequest(searchContextId, imageId, imageData, folder, storage);
                this.ImagingApi.AddSearchImage(request);
            }

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }

        
        // Delete image and images features from search context
        public void DeleteSearchImage()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string imageId = "WaterMark.bmp";
            string folder = null;
            string storage = null;

            DeleteSearchImageRequest request =
                    new DeleteSearchImageRequest(searchContextId, imageId, folder, storage);

            this.ImagingApi.DeleteSearchImage(request);

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }

        // Update image and images features in search context.
        // Image data is passed in a request stream.
        public void UpdateSearchImage()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string imageId = "WaterMark.bmp";
            string folder = null;
            string storage = null;

            // Input image
            using (FileStream imageData = File.OpenRead(ImagingBase.PathToDataFiles + imageId))
            {
                UpdateSearchImageRequest request =
                                new UpdateSearchImageRequest(searchContextId, imageId, imageData, folder, storage);
                this.ImagingApi.UpdateSearchImage(request);
            }

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }
    }
}
