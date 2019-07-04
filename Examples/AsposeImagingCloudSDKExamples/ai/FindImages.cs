// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FindImages.cs">
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

using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples.ai
{
    class FindImages : ImagingAIBase
    {
        private const string ImageToFind = "4.jpg";
        private const string ImageToFindByTag = "ComparingImageSimilar75.jpg";
        private const string ImagesPath = @"FindSimilar\";

        public void FindSimilarImages()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string findImageId = ImagesPath + ImageToFind;
            double? similarityThreshold = 3; // The similarity threshold
            int? maxCount = 3; // The maximum count
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage
            
            // Upload images to Cloud Storage
            string[] images = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg",
                                "9.jpg", "10.jpg"};
            foreach (string imageName in images)
            {
                // Upload local image to Cloud Storage
                using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + ImagesPath + imageName))
                {
                    var uploadFileRequest = new UploadFileRequest(ImagesPath + imageName, localInputImage);
                    FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
                }
            }

            this.CreateImageFeatures(ImagesPath.TrimEnd('\\'), true, searchContextId);

            SearchResultsSet searchResultsSet = this.ImagingApi.FindSimilarImages(
                    new FindSimilarImagesRequest(searchContextId, similarityThreshold, maxCount, imageId: findImageId, folder: folder, storage: storage));
            Console.WriteLine("Results Count: " + searchResultsSet.Results.Count);

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }

        public void FindImagesByTag()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string fileName = ImageToFindByTag;
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            this.CreateImageFeatures(ImagesPath.TrimEnd('\\'), true, searchContextId);

            string tagName = "ImageTag";
            double? similarityThreshold = 60;
            int? maxCount = 5;
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage

            this.ImagingApi.CreateImageTag(
                new CreateImageTagRequest(inputImageStream, searchContextId, tagName, folder, storage));

            var tags = JsonConvert.SerializeObject(new[] { tagName});
            SearchResultsSet searchResultsSet = this.ImagingApi.FindImagesByTags(
                new FindImagesByTagsRequest(tags, searchContextId, similarityThreshold, maxCount, storage: storage));

            // Process search results
            foreach (SearchResult searchResult in searchResultsSet.Results)
            {
                Console.WriteLine("ImageName: " + searchResult.ImageId +
                        ", Similarity: " + searchResult.Similarity);
            }

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }
    }
}
