//-----------------------------------------------------------------------------------------------------------
// <copyright file="FindImages.cs" company="Aspose" author="A. Ermakov" date="11/12/2019 2:52:13 PM">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Net;
using System.Web;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;

namespace AsposeImagingCloudSdkExamples.AI
{
    /// <summary>
    ///     Find images example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.AI.ImagingAiBase" />
    internal class FindSimilarImages : ImagingAiBase
    {
        private const string ImageToFind = "4.jpg";

        private const string ImageToFindByTag = "ComparingImageSimilar75.jpg";

        private const string ImagesPath = "FindSimilar";

        /// <summary>
        ///     Initializes a new instance of the <see cref="AI.FindSimilarImages" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public FindSimilarImages(ImagingApi imagingApi) : base(imagingApi)
        {
            Console.WriteLine("Find images example:");
            Console.WriteLine();
        }

        /// <summary>
        ///     Prepares the search context.
        /// </summary>
        public void PrepareSearchContext()
        {
            CreateSearchContext();

            string[] images =
            {
                "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg",
                "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg"
            };
            
            foreach (var imageName in images) UploadImageToCloud(Path.Combine(ImagesPath, imageName));
            
            CreateImageFeatures(ImagesPath, true);
            
            Console.WriteLine();
        }

        /// <summary>
        ///     Finds the similar images.
        /// </summary>
        public void FindImagesSimilar()
        {
            Console.WriteLine("Finds the similar images");

            var findImageId = $"{CloudPath}/{ImagesPath}/{ImageToFind}";
            double? similarityThreshold = 60; // The similarity threshold
            int? maxCount = 3; // The maximum count
            string folder = null;
            string storage = null; // We are using default Cloud Storage  

            var searchResultsSet = ImagingApi.FindSimilarImages(
                new FindSimilarImagesRequest(SearchContextId, similarityThreshold, maxCount, imageId: findImageId,
                    folder: folder, storage: storage));
            Console.WriteLine("Results Count: " + searchResultsSet.Results.Count);
            Console.WriteLine();
        }

        /// <summary>
        ///     Finds the images by tag.
        /// </summary>
        public void FindImagesByTag()
        {
            Console.WriteLine("Finds the images by tag");

            var fileName = ImageToFindByTag;
            var tagName = "ImageTag";
            double? similarityThreshold = 60;
            int? maxCount = 5;
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, fileName)))
            {
                ImagingApi.CreateImageTag(
                    new CreateImageTagRequest(inputImageStream, SearchContextId, tagName, folder, storage));
            }

            var tags = JsonConvert.SerializeObject(new[] {tagName});
            var searchResultsSet = ImagingApi.FindImagesByTags(
                new FindImagesByTagsRequest(tags, SearchContextId, similarityThreshold, maxCount, storage: storage));

            // Process search results
            foreach (var searchResult in searchResultsSet.Results)
                Console.WriteLine("ImageName: " + searchResult.ImageId +
                                  ", Similarity: " + searchResult.Similarity);

            Console.WriteLine();
        }

        /// <summary>
        ///     Finds the similar images from the URL source.
        /// </summary>
        public void SearchImageFromWebSource()
        {
            Console.WriteLine("Finds similar images from URL:");

            double? similarityThreshold = 30.0; // The similarity threshold
            int? maxCount = 3; // The maximum count
            var folder = CloudPath; // Path to input files
            string storage = null; // We are using default Cloud Storage

            var imagesSourceUrl = HttpUtility.UrlEncode("https://www.f1news.ru/interview/hamilton/140909.shtml");

            // Add images from the website to the search context
            ImagingApi.CreateWebSiteImageFeatures(
                new CreateWebSiteImageFeaturesRequest(SearchContextId, imagesSourceUrl, folder, storage));

            WaitIdle(SearchContextId);

            // Upload a sample file from that website
            // It will be resized to demonstrate search capabilities
            var imageName = CloudPath + "/" + "ReverseSearch.jpg";
            CreateSampleFile("https://cdn.f1ne.ws/userfiles/hamilton/140909.jpg", imageName, storage);

            // Find similar images in the search context
            var findResponse = ImagingApi.FindSimilarImages(new FindSimilarImagesRequest(SearchContextId,
                similarityThreshold, maxCount, imageId: CloudPath + "/" + "ReverseSearch.jpg", folder: folder,
                storage: storage));

            Console.WriteLine("Similar images found: " + findResponse.Results.Count);
        }

        /// <summary>
        ///     Creates a sample file in the cloud: downloads file from the url, resizes it and uploads to cloud.
        /// </summary>
        /// <param name="url">The file url.</param>
        /// <param name="path">The path in the cloud.</param>
        /// <param name="storage">The storage name.</param>
        private void CreateSampleFile(string url, string path, string storage = null)
        {
            using (var webClient = new WebClient())
            {
                // Download the image from the website
                var imageData = webClient.DownloadData(url);

                using (var imageStream = new MemoryStream(imageData))
                {
                    // Resize downloaded image
                    var rotatedImage = ImagingApi.CreateResizedImage(
                        new CreateResizedImageRequest(imageStream, 600, 400, "jpg", storage: storage));

                    var uploadFileRequest =
                        new UploadFileRequest(path, rotatedImage, storage);
                    ImagingApi.UploadFile(uploadFileRequest);
                }
            }
        }
    }
}