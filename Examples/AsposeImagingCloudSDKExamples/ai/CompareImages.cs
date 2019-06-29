using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples.ai
{
    class CompareImages : ImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        // Compare two images. Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
        public void CompareTwoImagesInSearchContext()
        {
            // Upload both images to Cloud Storage
            string[] images = { ComparableImage, ComparingImageSimilarMore75 };
            foreach (string imageName in images)
            {
                // Upload local image to Cloud Storage
                using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + imageName))
                {
                    var uploadFileRequest = new UploadFileRequest(imageName, localInputImage);
                    FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
                }
            }

            this.AddImageFeaturesToSearchContext(ComparableImage);
            this.AddImageFeaturesToSearchContext(ComparingImageSimilarMore75);

            // Compare two images
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            SearchResultsSet searchResults = this.ImagingApi.CompareImages(
                    new CompareImagesRequest(this.SearchContextId, ComparableImage, null, ComparingImageSimilarMore75, folder, storage));
            double? similarity = searchResults.Results[0].Similarity;
            Console.WriteLine("Images Similarity: " + similarity.ToString());
        }

        public void CompareLoadedImageToImageInSearchContext()
        {
            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + ComparableImage))
            {
                var uploadFileRequest = new UploadFileRequest(ComparableImage, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }
            
            this.AddImageFeaturesToSearchContext(ComparableImage);

            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + ComparingImageSimilarLess15);
            
            SearchResultsSet searchResults = this.ImagingApi.CompareImages(
                    new CompareImagesRequest(this.SearchContextId, ComparableImage, inputImageStream));
            double? similarity = searchResults.Results[0].Similarity;
            Console.WriteLine("Images Similarity: " + similarity.ToString());
        }
    }
}
