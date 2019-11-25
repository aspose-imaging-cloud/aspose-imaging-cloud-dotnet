//-----------------------------------------------------------------------------------------------------------
// <copyright file="FindImages.cs" company="Aspose" author="A. Ermakov" date="11/12/2019 2:52:13 PM">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples.AI
{
    /// <summary>
    /// Find images example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingAIBase" />
    class FindImages : ImagingAIBase
    {
        private const string ImageToFind = "4.jpg";

        private const string ImageToFindByTag = "ComparingImageSimilar75.jpg";

        private const string ImagesPath = "FindSimilar";

        /// <summary>
        /// Initializes a new instance of the <see cref="FindImages"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public FindImages(ImagingApi imagingApi) : base(imagingApi)
        {
            Console.WriteLine("Find images example:");
            Console.WriteLine();
        }

        /// <summary>
        /// Prepares the search context.
        /// </summary>
        public void PrepareSearchContext()
        {
            CreateSearchContext();

            string[] images = 
            {
                "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg",
                "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg"
            };

            foreach (string imageName in images)
            {
                UploadImageToCloud(imageName, ImagesPath);
            }

            CreateImageFeatures(ImagesPath, true);

            Console.WriteLine();
        }

        /// <summary>
        /// Finds the similar images.
        /// </summary>
        public void FindSimilarImages()
        {
            Console.WriteLine("Finds the similar images");

            string findImageId = $"{ImagesPath}/{ImageToFind}";
            double? similarityThreshold = 3; // The similarity threshold
            int? maxCount = 3; // The maximum count
            string folder = CloudPath; // Path to input files
            string storage = null; // We are using default Cloud Storage  

            SearchResultsSet searchResultsSet = this.ImagingApi.FindSimilarImages(
                    new FindSimilarImagesRequest(SearchContextId, similarityThreshold, maxCount, imageId: findImageId, folder: folder, storage: storage));
            Console.WriteLine("Results Count: " + searchResultsSet.Results.Count);
            Console.WriteLine();
        }

        /// <summary>
        /// Finds the images by tag.
        /// </summary>
        public void FindImagesByTag()
        {
            Console.WriteLine("Finds the images by tag");

            string fileName = ImageToFindByTag;
            string tagName = "ImageTag";
            double? similarityThreshold = 60;
            int? maxCount = 5;
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, fileName)))
            {
                this.ImagingApi.CreateImageTag(
                    new CreateImageTagRequest(inputImageStream, SearchContextId, tagName, folder, storage));
            }

            var tags = JsonConvert.SerializeObject(new[] { tagName });
            SearchResultsSet searchResultsSet = this.ImagingApi.FindImagesByTags(
                new FindImagesByTagsRequest(tags, SearchContextId, similarityThreshold, maxCount, storage: storage));

            // Process search results
            foreach (SearchResult searchResult in searchResultsSet.Results)
            {
                Console.WriteLine("ImageName: " + searchResult.ImageId +
                        ", Similarity: " + searchResult.Similarity);
            }

            Console.WriteLine();
        }
    }
}