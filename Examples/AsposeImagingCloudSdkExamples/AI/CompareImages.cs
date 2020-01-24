//-----------------------------------------------------------------------------------------------------------
// <copyright file="CompareImages.cs" company="Aspose" author="A. Ermakov" date="11/12/2019 2:52:12 PM">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples.AI
{
    /// <summary>
    ///     Compare images example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.AI.ImagingAiBase" />
    internal class CompareImages : ImagingAiBase
    {
        private const string ComparableImage = "ComparableImage.jpg";

        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";

        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        /// <summary>
        ///     Initializes a new instance of the <see cref="CompareImages" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public CompareImages(ImagingApi imagingApi) : base(imagingApi)
        {
            Console.WriteLine("Compare images example:");
            Console.WriteLine();
        }

        /// <summary>
        ///     Prepares the search context.
        /// </summary>
        public void PrepareSearchContext()
        {
            CreateSearchContext();

            string[] images = {ComparableImage, ComparingImageSimilarMore75};
            foreach (var imageName in images) UploadImageToCloud(imageName);

            CreateImageFeatures(ComparableImage, false);
            CreateImageFeatures(ComparingImageSimilarMore75, false);

            Console.WriteLine();
        }

        /// <summary>
        ///     Compares the two images in cloud.
        /// </summary>
        public void CompareTwoImagesInCloud()
        {
            Console.WriteLine("Compares the two images in cloud storage:");

            // Compare two images
            var folder = CloudPath; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            Console.WriteLine(
                $"Call CompareImages with params: image1:{ComparableImage}, image2:{ComparingImageSimilarMore75}");

            var request = new CompareImagesRequest(SearchContextId, ComparableImage, null, ComparingImageSimilarMore75,
                folder, storage);
            var searchResults = ImagingApi.CompareImages(request);

            var similarity = searchResults.Results[0].Similarity;
            Console.WriteLine("Images Similarity: " + similarity);

            Console.WriteLine();
        }

        /// <summary>
        ///     Compares the loaded image to image in cloud.
        /// </summary>
        public void CompareLoadedImageToImageInCloud()
        {
            Console.WriteLine("Compares the loaded image to image in cloud storage:");

            using (var inputImageStream = File.OpenRead(Path.Combine(ExampleImagesFolder, ComparingImageSimilarLess15)))
            {
                var request = new CompareImagesRequest(SearchContextId, ComparableImage, inputImageStream);
                
                Console.WriteLine($"Call CompareImages with params: image:{ComparableImage}");

                var searchResults = ImagingApi.CompareImages(request);
                var similarity = searchResults.Results[0].Similarity;
                Console.WriteLine("Images Similarity: " + similarity);
            }

            Console.WriteLine();
        }
    }
}