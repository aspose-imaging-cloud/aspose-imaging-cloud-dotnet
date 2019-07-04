// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagingAIBase.cs">
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

namespace AsposeImagingCloudSDKExamples
{
    class ImagingAIBase : ImagingBase
    {
        protected string CreateImageSearch()
        {
            string detector = "akaze";
            string matchingAlgorithm = "randomBinaryTree";
            string folder = null; // File will be saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            CreateImageSearchRequest createSearchContextRequest = new CreateImageSearchRequest(detector,
                                                                                        matchingAlgorithm, folder, storage);
            SearchContextStatus status = this.ImagingApi.CreateImageSearch(createSearchContextRequest);
            return status.Id;
        }
        
        // Delete the search context
        protected void DeleteImageSearch(string searchContextId)
        {
            string folder = null; // File is saved at the root of the storage
            string storage = null; // Default Cloud Storage is being used

            DeleteImageSearchRequest deleteSearchContextRequest = new DeleteImageSearchRequest(searchContextId,
                                                                                                    folder, storage);
            this.ImagingApi.DeleteImageSearch(deleteSearchContextRequest);
        }

        // Gets the search context status
        protected string GetImageSearchStatus(string searchContextId)
        {
            string folder = null; // File is saved at the root of the storage
            string storage = null; // Default Cloud Storage is being used

            GetImageSearchStatusRequest searchContextStatusRequest = new GetImageSearchStatusRequest(searchContextId,
                                                                                                        folder, storage);

            SearchContextStatus status = this.ImagingApi.GetImageSearchStatus(searchContextStatusRequest);
            return status.SearchStatus;
        }

        // Extract images features and add them to search context.
        protected void CreateImageFeatures(string storageSourcePath, bool isFolder, string searchContextId)
        {
            var request = isFolder
                   ? new CreateImageFeaturesRequest(searchContextId, imageId: null, imagesFolder: storageSourcePath, storage: null)
                   : new CreateImageFeaturesRequest(searchContextId, imageId: storageSourcePath, storage: null);
            this.ImagingApi.CreateImageFeatures(request);
        }

        // Gets image features from search context.
        protected void GetImageFeatures(string imageName, string searchContextId)
        {
            GetImageFeaturesRequest getImageFeaturesRequest =
                                    new GetImageFeaturesRequest(searchContextId, imageId: imageName);
            ImageFeatures imageFeatures = this.ImagingApi.GetImageFeatures(getImageFeaturesRequest);   
        }
        
        // Deletes image features from search context.
        protected void DeleteImageFeatures(string imageName, string searchContextId)
        { 
            DeleteImageFeaturesRequest deleteImageFeaturesRequest =
                                new DeleteImageFeaturesRequest(searchContextId, imageId: imageName);
            this.ImagingApi.DeleteImageFeatures(deleteImageFeaturesRequest);   
        }

        // Update images features in search context.
        protected void UpdateImageFeatures(string imageName, string searchContextId)
        {
            UpdateImageFeaturesRequest updateImageFeaturesRequest =
                            new UpdateImageFeaturesRequest(searchContextId, imageId: imageName);
            this.ImagingApi.UpdateImageFeatures(updateImageFeaturesRequest);
        }
    }
}
