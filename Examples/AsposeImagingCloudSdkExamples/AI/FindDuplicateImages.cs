//-----------------------------------------------------------------------------------------------------------
// <copyright file="FindDuplicateImages.cs" company="Aspose" author="A. Ermakov" date="11/12/2019 2:52:13 PM">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using System;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;

namespace AsposeImagingCloudSdkExamples.AI
{
    /// <summary>
    ///     Find duplicate images example.
    /// </summary>
    /// <seealso cref="AsposeImagingCloudSdkExamples.AI.ImagingAiBase" />
    internal class FindDuplicateImages : ImagingAiBase
    {
        private const string ComparableImage = "ComparableImage.jpg";

        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";

        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        /// <summary>
        ///     Initializes a new instance of the <see cref="FindDuplicateImages" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public FindDuplicateImages(ImagingApi imagingApi) : base(imagingApi)
        {
            Console.WriteLine("Find duplicate images example:");
            Console.WriteLine();
        }

        /// <summary>
        ///     Prepares the search context.
        /// </summary>
        public void PrepareSearchContext()
        {
            CreateSearchContext();

            string[] images = {ComparableImage, ComparingImageSimilarLess15, ComparingImageSimilarMore75};
            foreach (var imageName in images) UploadImageToCloud(imageName);

            CreateImageFeatures(ComparableImage, false);
            CreateImageFeatures(ComparingImageSimilarLess15, false);
            CreateImageFeatures(ComparingImageSimilarMore75, false);

            Console.WriteLine();
        }

        /// <summary>
        ///     Finds the image duplicates.
        /// </summary>
        public void FindImageDuplicates()
        {
            Console.WriteLine("Finds the image duplicates");

            double? similarityThreshold = 70;
            var folder = CloudPath; // Path to input files
            string storage = null; // We are using default Cloud Storage

            var imageDuplicatesSet = ImagingApi.FindImageDuplicates(
                new FindImageDuplicatesRequest(SearchContextId, similarityThreshold, folder, storage));
            Console.WriteLine("Duplicates Count: " + imageDuplicatesSet.Duplicates.Count);
            Console.WriteLine();
        }
    }
}