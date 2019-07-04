// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FindDuplicateImages.cs">
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
    class FindDuplicateImages : ImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";
        
        public void FindImageDuplicates()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            // Upload input images to Cloud Storage
            string[] images = { ComparableImage, ComparingImageSimilarLess15, ComparingImageSimilarMore75 };
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
            this.CreateImageFeatures(ComparingImageSimilarLess15, false, searchContextId);
            this.CreateImageFeatures(ComparingImageSimilarMore75, false, searchContextId);

            double? similarityThreshold = 80; // The similarity threshold
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage

            ImageDuplicatesSet imageDuplicatesSet = this.ImagingApi.FindImageDuplicates(
                    new FindImageDuplicatesRequest(searchContextId, similarityThreshold, folder, storage));
            Console.WriteLine("Duplicates Count: " + imageDuplicatesSet.Duplicates.Count);

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }
    }
}
