using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples
{
    class SearchContextImages : ImagingAIBase
    {
        // Get image from search context
        public void getImageFromSearchContext()
        {
            string imageId = "WaterMark.bmp";
            string folder = null;
            string storage = null;

            GetSearchImageRequest request =
                                            new GetSearchImageRequest(this.SearchContextId, imageId, folder, storage);
            Stream retrievedImage = this.ImagingApi.GetSearchImage(request);

            // Save retrieved image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out.bmp"))
            {
                retrievedImage.Seek(0, SeekOrigin.Begin);
                retrievedImage.CopyTo(fileStream);
            }
        }

        
        // Add image and images features to search context.
        // Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
        public void addImageAndImagesFeaturesToSearchContext()
        {
            string imageId = "WaterMark.bmp";

            // Input image
            FileStream imageData = File.OpenRead(ImagingBase.PathToDataFiles + imageId);
            
            string folder = null;
            string storage = null;

            AddSearchImageRequest request =
                            new AddSearchImageRequest(this.SearchContextId, imageId, imageData, folder, storage);
            this.ImagingApi.AddSearchImage(request);
        }

        
        // Delete image and images features from search context
        public void deleteImageAndImagesFeaturesFromSearchContext()
        {
            string imageId = "WaterMark.bmp";
            string folder = null;
            string storage = null;

            DeleteSearchImageRequest request =
                    new DeleteSearchImageRequest(this.SearchContextId, imageId, folder, storage);

            this.ImagingApi.DeleteSearchImage(request);   
        }
        
        // Update image and images features in search context.
        // Image data may be passed as zero-indexed multipart/form-data content or as raw body stream.
        public void updateImageAndImagesFeaturesInSearchContext()
        {
            string imageId = "WaterMark.bmp";
            // Input image
            FileStream imageData = File.OpenRead(ImagingBase.PathToDataFiles + imageId);
            string folder = null;
            string storage = null;

            UpdateSearchImageRequest request =
                            new UpdateSearchImageRequest(this.SearchContextId, imageId, imageData, folder, storage);
            this.ImagingApi.UpdateSearchImage(request);
        }
    }
}
