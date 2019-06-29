using Aspose.Imaging.Cloud.Sdk.Api;
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
    class SearchContext : ImagingAIBase
    {
        
        // Extract features from image without adding to search context.
        // Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
        public void extractFeaturesFromImageWithoutAddingToSearchContext()
        {
            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Extract features from image without adding to search context
            string folder = null; // Folder with image to process
            string storage = null; // We are using default Cloud Storage

            ExtractImageFeaturesRequest extractImageFeaturesRequest =
                    new ExtractImageFeaturesRequest(this.SearchContextId, fileName, null, folder, storage);

            ImageFeatures imageFeatures = this.ImagingApi.ExtractImageFeatures(extractImageFeaturesRequest);
            Console.WriteLine(imageFeatures);
        }
        
        // Add tag and reference image to search context.
        // Image data is passed as zero-indexed multipart/form-data content or as raw body stream. 
        public void addTagAndReferenceImageToSearchContext()
        {
            string tag = "MyTag";
            string imageName = "aspose_logo.png";
            string folder = null; // File will be saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            // Load tag image as a stream
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + imageName);
            
            this.ImagingApi.CreateImageTag(
                    new CreateImageTagRequest(inputImageStream, this.SearchContextId, tag, folder, storage));
        }
    }
}
