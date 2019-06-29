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
    class TIFFImage : ImagingBase
    {
        // Update parameters of TIFF image. The image is saved in the cloud.
        public void updateParametersOfTIFFImageInCloud()
        {
            string fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Update parameters of TIFF image
            string compression = "adobedeflate";
            string resolutionUnit = "inch";
            int? bitDepth = 1;
            double horizontalResolution = 150;
            double verticalResolution = 150;
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            ModifyTiffRequest getImageTiffRequest = new ModifyTiffRequest(fileName, bitDepth, compression, resolutionUnit,
                                                            horizontalResolution, verticalResolution, fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyTiff(getImageTiffRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.tiff"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
        
        // Update parameters of TIFF image. Image data is passed as zero-indexed multipart/form-data
        // content or as raw body stream.
        public void updateParametersOfTIFFImageInRequestBody()
        {
            string fileName = "Sample.tiff";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            string compression = "adobedeflate";
            string resolutionUnit = "inch";
            int? bitDepth = 1;
            double horizontalResolution = 150;
            double verticalResolution = 150;
            bool? fromScratch = null;
            string outPath = null;
            string storage = null; // We are using default Cloud Storage

            CreateModifiedTiffRequest postImageTiffRequest = new CreateModifiedTiffRequest(inputImageStream, bitDepth, compression,
                                    resolutionUnit, horizontalResolution, verticalResolution, fromScratch, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateModifiedTiff(postImageTiffRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.tiff"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Update parameters of TIFF image according to fax parameters.
        public void updateParametersOfTIFFImageAccordingToFaxParameters()
        {
            String fileName = "Sample.tiff";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Update TIFF Image parameters according to fax parameters
            String folder = null; // Input file is saved at the root of the storage
            String storage = null; // We are using default Cloud Storage

            ConvertTiffToFaxRequest getTiffToFaxRequest = new ConvertTiffToFaxRequest(fileName, storage, folder);

            Stream updatedImage = this.ImagingApi.ConvertTiffToFax(getTiffToFaxRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.tiff"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        // Appends existing TIFF image to another existing TIFF image (i.e. merges TIFF images).
        public void mergeTIFFImages()
        {
            String fileName = "Sample.tiff"; // Original image file name
            String appendFileName = "Memorandum.tif"; // Image file name to be appended to original one
            
            // Upload original image file to cloud storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Upload file be appended to cloud storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + appendFileName))
            {
                var uploadFileRequest = new UploadFileRequest(appendFileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Update TIFF Image parameters according to fax parameters
            String folder = null; // Input file is saved at the root of the storage
            String storage = null; // We are using default Cloud Storage

            AppendTiffRequest request = new AppendTiffRequest(fileName, appendFileName, storage, folder);
            this.ImagingApi.AppendTiff(request);

            // Download updated file to local storage
            DownloadFileRequest downloadFileRequest = new DownloadFileRequest(fileName, storage, null);
            Stream updatedImage = this.ImagingApi.DownloadFile(downloadFileRequest);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.tiff"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
