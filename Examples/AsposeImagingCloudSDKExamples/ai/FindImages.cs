using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples.ai
{
    class FindImages : ImagingAIBase
    {
        private const string ImageToFind = "4.jpg";
        private const string ImageToFindByTag = "ComparingImageSimilar75.jpg";
        private const string ImagesPath = @"FindSimilar\";

        public void FindSimilarImages()
        {
            string findImageId = ImagesPath + ImageToFind;
            double? similarityThreshold = 3; // The similarity threshold
            int? maxCount = 3; // The maximum count
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage
            
            // Upload images to Cloud Storage
            string[] images = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg",
                                "9.jpg", "10.jpg"};
            foreach (string imageName in images)
            {
                // Upload local image to Cloud Storage
                using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + ImagesPath + imageName))
                {
                    var uploadFileRequest = new UploadFileRequest(ImagesPath + imageName, localInputImage);
                    FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
                }
            }

            this.AddImageFeaturesToSearchContext(ImagesPath.TrimEnd('\\'), true);

            SearchResultsSet searchResultsSet = this.ImagingApi.FindSimilarImages(
                    new FindSimilarImagesRequest(this.SearchContextId, similarityThreshold, maxCount, imageId: findImageId, folder: folder, storage: storage));
            Console.WriteLine("Results Count: " + searchResultsSet.Results.Count);
        }

        public void FindSimilarImagesByTag()
        {
            string fileName = ImageToFindByTag;
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            this.AddImageFeaturesToSearchContext(ImagesPath.TrimEnd('\\'), true);

            string tagName = "ImageTag";
            double? similarityThreshold = 60;
            int? maxCount = 5;
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage

            this.ImagingApi.CreateImageTag(
                new CreateImageTagRequest(inputImageStream, this.SearchContextId, tagName, folder, storage));

            var tags = JsonConvert.SerializeObject(new[] { tagName});
            SearchResultsSet searchResultsSet = this.ImagingApi.FindImagesByTags(
                new FindImagesByTagsRequest(tags, this.SearchContextId, similarityThreshold, maxCount, storage: storage));

            // Process search results
            foreach (SearchResult searchResult in searchResultsSet.Results)
            {
                Console.WriteLine("ImageName: " + searchResult.ImageId +
                        ", Similarity: " + searchResult.Similarity);
            }
        }
    }
}
