// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SearchContext.cs">
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
    class SearchContext : ImagingAIBase
    {
        
        // Extract features from image without adding to search context.
        public void ExtractImageFeatures()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Extract features from image without adding to search context
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            ExtractImageFeaturesRequest extractImageFeaturesRequest =
                    new ExtractImageFeaturesRequest(searchContextId, fileName, null, folder, storage);

            ImageFeatures imageFeatures = this.ImagingApi.ExtractImageFeatures(extractImageFeaturesRequest);
            Console.WriteLine(imageFeatures);

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }

        // Add tag and reference image to search context.
        // Image data is passed in a request stream. 
        public void CreateImageTag()
        {
            // Create new search context
            string searchContextId = this.CreateImageSearch();

            string tag = "MyTag";
            string imageName = "aspose_logo.png";
            string folder = null; // File will be saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            // Load tag image as a stream
            using (FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + imageName))
            {
                this.ImagingApi.CreateImageTag(
                        new CreateImageTagRequest(inputImageStream, searchContextId, tag, folder, storage));
            }

            // Delete the search context
            this.DeleteImageSearch(searchContextId);
        }
    }
}
