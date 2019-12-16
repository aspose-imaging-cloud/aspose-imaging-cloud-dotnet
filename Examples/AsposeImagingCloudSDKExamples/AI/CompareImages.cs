//-----------------------------------------------------------------------------------------------------------
// <copyright file="CompareImages.cs" company="Aspose" author="A. Ermakov" date="11/12/2019 2:52:12 PM">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples.AI
{
    /// <summary>
    /// Compare images example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSDKExamples.ImagingAIBase" />
    class CompareImages : ImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        /// <summary>
        /// Initializes a new instance of the <see cref="CompareImages"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public CompareImages(ImagingApi imagingApi) : base(imagingApi)
        {
            Console.WriteLine("Compare images example:");
            Console.WriteLine();
        }

        /// <summary>
        /// Prepares the search context.
        /// </summary>
        public void PrepareSearchContext()
        {
            CreateSearchContext();

            // Upload images to Cloud Storage
            string[] images = { ComparableImage, ComparingImageSimilarMore75 };
            foreach (string imageName in images)
            {
                // Upload local image to Cloud Storage
                UploadImageToCloud(imageName);
            }

            this.CreateImageFeatures(ComparableImage, false);
            this.CreateImageFeatures(ComparingImageSimilarMore75, false);

            Console.WriteLine();
        }

        /// <summary>
        /// Compares the two images in cloud.
        /// </summary>
        public void CompareTwoImagesInCloud()
        {
            Console.WriteLine("Compares the two images in cloud storage:");            

            // Compare two images
            string folder = CloudPath; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            Console.WriteLine($"Call CompareImages with params: image1:{ComparableImage}, image2:{ComparingImageSimilarMore75}");

            SearchResultsSet searchResults = this.ImagingApi.CompareImages(
                    new CompareImagesRequest(SearchContextId, ComparableImage, null, ComparingImageSimilarMore75, folder, storage));
    
            double? similarity = searchResults.Results[0].Similarity;
            Console.WriteLine("Images Similarity: " + similarity.ToString());       

            Console.WriteLine();
        }

        /// <summary>
        /// Compares the loaded image to image in cloud.
        /// </summary>
        public void CompareLoadedImageToImageInCloud()
        {
            Console.WriteLine(" Compares the loaded image to image in cloud storage:");

            using (FileStream inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, ComparingImageSimilarLess15)))
            {
                Console.WriteLine($"Call CompareImages with params: image:{ComparableImage}");

                SearchResultsSet searchResults = this.ImagingApi.CompareImages(
                        new CompareImagesRequest(SearchContextId, ComparableImage, inputImageStream));
                double? similarity = searchResults.Results[0].Similarity;
                Console.WriteLine("Images Similarity: " + similarity.ToString());
            }

            Console.WriteLine();
        }
    }
}