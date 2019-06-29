using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples
{
    class ImagingAIBase : ImagingBase
    {
        protected string SearchContextId { get; private set; }
        
        public ImagingAIBase()
        {
            this.SearchContextId = this.CreateSearchContext();
        }

        protected string CreateSearchContext()
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
        protected void DeleteSearchContext(string searchContextId)
        {
            string folder = null; // File is saved at the root of the storage
            string storage = null; // Default Cloud Storage is being used

            DeleteImageSearchRequest deleteSearchContextRequest = new DeleteImageSearchRequest(searchContextId,
                                                                                                    folder, storage);
            this.ImagingApi.DeleteImageSearch(deleteSearchContextRequest);
        }

        // Gets the search context status
        protected string GetTheSearchContextStatus(string searchContextId)
        {
            string folder = null; // File is saved at the root of the storage
            string storage = null; // Default Cloud Storage is being used

            GetImageSearchStatusRequest searchContextStatusRequest = new GetImageSearchStatusRequest(searchContextId,
                                                                                                        folder, storage);

            SearchContextStatus status = this.ImagingApi.GetImageSearchStatus(searchContextStatusRequest);
            return status.SearchStatus;
        }

        // Extract images features and add them to search context.
        // Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
        protected void AddImageFeaturesToSearchContext(string storageSourcePath, bool isFolder = false)
        {
            var request = isFolder
                   ? new CreateImageFeaturesRequest(this.SearchContextId, imageId: null, imagesFolder: storageSourcePath, storage: null)
                   : new CreateImageFeaturesRequest(this.SearchContextId, imageId: storageSourcePath, storage: null);
            this.ImagingApi.CreateImageFeatures(request);
        }

        // Gets image features from search context.
        protected void GetImageFeaturesFromSearchContext(string imageName)
        {
            GetImageFeaturesRequest getImageFeaturesRequest =
                                    new GetImageFeaturesRequest(this.SearchContextId, imageId: imageName);
            ImageFeatures imageFeatures = this.ImagingApi.GetImageFeatures(getImageFeaturesRequest);   
        }
        
        // Deletes image features from search context.
        protected void DeleteImageFeaturesFromSearchContext(string imageName)
        { 
            DeleteImageFeaturesRequest deleteImageFeaturesRequest =
                                new DeleteImageFeaturesRequest(this.SearchContextId, imageId: imageName);
            this.ImagingApi.DeleteImageFeatures(deleteImageFeaturesRequest);   
        }

        // Update images features in search context.
        // Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
        protected void UpdateImageFeaturesInSearchContext(string imageName)
        {
            UpdateImageFeaturesRequest updateImageFeaturesRequest =
                            new UpdateImageFeaturesRequest(this.SearchContextId, imageId: imageName);
            this.ImagingApi.UpdateImageFeatures(updateImageFeaturesRequest);
        }
    }
}
