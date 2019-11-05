// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareImages.cs">
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
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples.ai
{
    class CompareImages : ImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";
        
        // Compare two images. 
        public void CompareTwoImagesInSearchContext()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            // Upload both images to Cloud Storage
            string[] images = { ComparableImage, ComparingImageSimilarMore75 };
            foreach (string imageName in images)
            {
                // Upload local image to Cloud Storage
                using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + imageName))
                {
                    var uploadFileRequest = new UploadFileRequest(imageName, localInputImage);
                    FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
                }
            }

            this.CreateImageFeatures(ComparableImage, false, searchContextId);
            this.CreateImageFeatures(ComparingImageSimilarMore75, false, searchContextId);

            // Compare two images
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            SearchResultsSet searchResults = this.ImagingApi.CompareImages(
                    new CompareImagesRequest(searchContextId, ComparableImage, null, ComparingImageSimilarMore75, folder, storage));
            double? similarity = searchResults.Results[0].Similarity;
            Console.WriteLine("Images Similarity: " + similarity.ToString());

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }

        public void CompareLoadedImageToImageInSearchContext()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + ComparableImage))
            {
                var uploadFileRequest = new UploadFileRequest(ComparableImage, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
            
            this.CreateImageFeatures(ComparableImage, false, searchContextId);

            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + ComparingImageSimilarLess15);
            
            SearchResultsSet searchResults = this.ImagingApi.CompareImages(
                    new CompareImagesRequest(searchContextId, ComparableImage, inputImageStream));
            double? similarity = searchResults.Results[0].Similarity;
            Console.WriteLine("Images Similarity: " + similarity.ToString());

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }
    }
}
