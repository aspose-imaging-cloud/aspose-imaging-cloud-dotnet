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
    class ExportImage : ImagingBase
    {
        public void exportImageToAnotherFormat()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "WaterMark.bmp";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            // Output formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG, SVG and PDF
            string format = "pdf";
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // Cloud Storage name
            
            var request = new SaveImageAsRequest(fileName, format, folder, storage);
            Stream updatedImage = this.ImagingApi.SaveImageAs(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }

        public void exportImageToAnotherFormatWithoutStorage()
        {
            // Input formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG and SVG
            string fileName = "WaterMark.bmp";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            // Output formats could be one of the following:
            // BMP,	GIF, DJVU, WMF, EMF, JPEG, JPEG2000, PSD, TIFF, WEBP, PNG, DICOM, CDR, CMX, ODG, DNG, SVG and PDF
            string format = "pdf";
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
            string storage = null; // Cloud Storage name
            
            var request = new CreateSavedImageAsRequest(inputImageStream, format, outPath, storage);
            Stream updatedImage = this.ImagingApi.CreateSavedImageAs(request);

            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Watermark_out." + format))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
