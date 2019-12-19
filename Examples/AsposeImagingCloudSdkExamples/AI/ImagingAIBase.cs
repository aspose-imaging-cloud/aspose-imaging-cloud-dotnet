//-----------------------------------------------------------------------------------------------------------
// <copyright file="ImagingAIBase.cs" company="Aspose" author="A. Ermakov" date="11/12/2019 2:52:13 PM">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Threading;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples.AI
{
    internal abstract class ImagingAiBase
    {
        /// <summary>
        ///     The example images folder path.
        /// </summary>
        protected const string ExampleImagesFolder = @"..\..\..\..\Examples\Images\AI";

        /// <summary>
        ///     The cloud path.
        /// </summary>
        protected const string CloudPath = "Examples/AI";

        /// <summary>
        ///     Initializes a new instance of the <see cref="ImagingBase" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public ImagingAiBase(ImagingApi imagingApi)
        {
            ImagingApi = imagingApi;
        }

        /// <summary>
        ///     Gets the imaging API.
        /// </summary>
        /// <value>
        ///     The imaging API.
        /// </value>
        protected ImagingApi ImagingApi { get; }

        /// <summary>
        ///     Gets the search context identifier.
        /// </summary>
        /// <value>
        ///     The search context identifier.
        /// </value>
        protected string SearchContextId { get; private set; }

        /// <summary>
        ///     Creates the image search.
        /// </summary>
        /// <returns>The search context identifier.</returns>
        protected void CreateSearchContext()
        {
            string detector = "akaze";
            string matchingAlgorithm = "randomBinaryTree";
            string folder = null; // File will be saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            var createSearchContextRequest =
                new CreateImageSearchRequest(detector, matchingAlgorithm, folder, storage);
            var status = ImagingApi.CreateImageSearch(createSearchContextRequest);
            SearchContextId = status.Id;

            Console.WriteLine($"Created new Search context with SearchContextId={SearchContextId}");
        }

        /// <summary>
        ///     Deletes the image search context.
        /// </summary>
        public void DeleteSearchContext()
        {
            string folder = null; // File is saved at the root of the storage
            string storage = null; // Default Cloud Storage is being used

            var deleteSearchContextRequest =
                new DeleteImageSearchRequest(SearchContextId, folder, storage);
            ImagingApi.DeleteImageSearch(deleteSearchContextRequest);

            Console.WriteLine($"Deleted new Search context with SearchContextId={SearchContextId}");
            Console.WriteLine();
        }

        /// <summary>
        ///     Waits the idle.
        /// </summary>
        /// <param name="searchContextId">The search context identifier.</param>
        private void WaitIdle(string searchContextId)
        {
            Console.WriteLine("Waiting Search context Idle...");

            while (GetImageSearchStatus(searchContextId) != "Idle") Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        /// <summary>
        ///     Gets the image search status.
        /// </summary>
        /// <param name="searchContextId">The search context identifier.</param>
        /// <returns>The image search status.</returns>
        private string GetImageSearchStatus(string searchContextId)
        {
            string folder = null; // File is saved at the root of the storage
            string storage = null; // Default Cloud Storage is being used

            var searchContextStatusRequest =
                new GetImageSearchStatusRequest(searchContextId, folder, storage);

            var status = ImagingApi.GetImageSearchStatus(searchContextStatusRequest);
            return status.SearchStatus;
        }

        /// <summary>
        ///     Extract images features and add them to search context.
        /// </summary>
        /// <param name="sourcePath">The storage source path.</param>
        /// <param name="isFolder">if set to <c>true</c> [is folder].</param>
        protected void CreateImageFeatures(string sourcePath, bool isFolder)
        {
            var request = isFolder
                ? new CreateImageFeaturesRequest(SearchContextId, imageId: null,
                    imagesFolder: Path.Combine(CloudPath, sourcePath))
                : new CreateImageFeaturesRequest(SearchContextId, imageId: Path.Combine(CloudPath, sourcePath));
            ImagingApi.CreateImageFeatures(request);

            if (isFolder)
            {
                Console.WriteLine("Creating Search context image features...");

                WaitIdle(SearchContextId);
            }
            else
            {
                Console.WriteLine($"Created Search context image features for {sourcePath}");
            }
        }

        /// <summary>
        ///     Uploads the image to cloud.
        /// </summary>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="subFolder">Name of the subfolder.</param>
        protected void UploadImageToCloud(string imageName, string subFolder = null)
        {
            var folder = subFolder != null
                ? Path.Combine(ExampleImagesFolder, subFolder)
                : ExampleImagesFolder;

            using (var localInputImage = File.OpenRead(Path.Combine(folder, imageName)))
            {
                var uploadFileRequest = new UploadFileRequest(Path.Combine(CloudPath, imageName), localInputImage);
                ImagingApi.UploadFile(uploadFileRequest);
            }

            Console.WriteLine($"Image {imageName} was uploaded to cloud storage");
        }
    }
}