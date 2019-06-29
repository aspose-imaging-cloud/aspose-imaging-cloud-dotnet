using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeImagingCloudSDKExamples
{
    class WMFImage : ImagingBase
    {
        // Process existing WMF image using given parameters. The image is saved in the cloud.
        public void updateParametersOfWMFImageInCloud()
        {
            string fileName = "Sample.wmf";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string bkColor = "gray";
            int? pageWidth = 300;
            int? pageHeight = 300;
            int? borderX = 50;
            int? borderY = 50;
            bool? fromScratch = null;
            string outPath = null;  // Path to updated file (if this is empty, response contains streamed image).
            string folder = null;   // Folder with image to process. The value is null because the file is saved at the root of the storage

            string storage = null; // We are using default Cloud Storage
            string exportFormat = "png";

            ModifyWmfRequest getImageWmfRequest = new ModifyWmfRequest(fileName, bkColor, pageWidth, pageHeight,
                                                                    borderX, borderY, fromScratch, folder,
                                                                                                storage, exportFormat);

            Stream updatedImage = this.ImagingApi.ModifyWmf(getImageWmfRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "WMFToPNG_out.png"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
        
        // Process existing WMF image using given parameters.
        // Image data is passed as zero-indexed multipart/form-data content or as raw body stream.
        public void updateParametersOfWMFImageInRequestBody()
        {
            string fileName = "Sample.wmf";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);
            
            string bkColor = "gray";
            int? pageWidth = 300;
            int? pageHeight = 300;
            int? borderX = 50;
            int? borderY = 50;
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image).
            string storage = null; // We are using default Cloud Storage
            string exportFormat = "png";

            CreateModifiedWmfRequest postImageWmfRequest = new CreateModifiedWmfRequest(inputImageStream, bkColor, pageWidth,
                                                                pageHeight, borderX, borderY, fromScratch, outPath,
                                                                                                storage, exportFormat);


            Stream updatedImage = this.ImagingApi.CreateModifiedWmf(postImageWmfRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "WMFToPNG_out.png"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
