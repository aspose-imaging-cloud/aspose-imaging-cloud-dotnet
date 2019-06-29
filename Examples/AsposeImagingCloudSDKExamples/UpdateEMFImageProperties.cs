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
    class UpdateEMFImageProperties : ImagingBase
    {
        //  Process existing EMF imaging using given parameters
        public void processEMFImage()
        {
            string fileName = "Sample.emf";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            string format = "png";
            // Specifies where additional parameters we do not support should be taken from.
            // If this is true – they will be taken from default values for standard image,
            // if it is false – they will be saved from current image. Default is false.
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // As we are using default Cloud Storage

            var request = new ModifyEmfRequest(fileName, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, folder, storage, format);
            Stream updatedImage = this.ImagingApi.ModifyEmf(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SampleEMF_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Rasterize EMF image to PNG using given parameters. Image is passed in a request stream
        public void processEMFImageWithoutStorage()
        {
            string fileName = "Sample.emf";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            string format = "png";
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
            string storage = null; // As we are using default Cloud Storage

            var request = new CreateModifiedEmfRequest(inputImageStream, bkColor, pageWidth, pageHeigth, 
                                                    borderX, borderY, fromScratch, outPath, storage, format);
            Stream updatedImage = this.ImagingApi.CreateModifiedEmf(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "SampleEMF_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
