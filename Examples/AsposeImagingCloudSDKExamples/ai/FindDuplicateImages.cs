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
    class FindDuplicateImages : ImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        public void FindDuplicates()
        {
            // Upload input images to Cloud Storage
            string[] images = { ComparableImage, ComparingImageSimilarLess15, ComparingImageSimilarMore75 };
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
            this.AddImageFeaturesToSearchContext(ComparingImageSimilarLess15);
            this.AddImageFeaturesToSearchContext(ComparingImageSimilarMore75);

            double? similarityThreshold = 80; // The similarity threshold
            string folder = null; // Path to input files
            string storage = null; // We are using default Cloud Storage

            ImageDuplicatesSet imageDuplicatesSet = this.ImagingApi.FindImageDuplicates(
                    new FindImageDuplicatesRequest(this.SearchContextId, similarityThreshold, folder, storage));
            Console.WriteLine("Duplicates Count: " + imageDuplicatesSet.Duplicates.Count);
        }
    }
}
