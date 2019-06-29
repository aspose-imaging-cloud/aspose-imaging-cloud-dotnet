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
    class UpdateJPEG2000Image : ImagingBase
    {
        // Update parameters of existing JPEG2000 image. The image is saved in the cloud.
        public void updateParametersOfJPEG2000ImageInCloud()
        {
            string fileName = "Sample.jp2";

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(ImagingBase.PathToDataFiles + fileName))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = this.ImagingApi.UploadFile(uploadFileRequest);
            }

            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // We are using default Cloud Storage

            ModifyJpeg2000Request getImageJpeg2000Request = new ModifyJpeg2000Request(fileName, comment, codec,
                                                                                fromScratch, folder, storage);

            Stream updatedImage = this.ImagingApi.ModifyJpeg2000(getImageJpeg2000Request);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jp2"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
        
        // Update parameters of existing JPEG2000 image. Image is passed in a request stream.
        public void updateParametersOfJPEG2000ImageInRequestBody()
        {
            string fileName = "Sample.jp2";
            FileStream inputImageStream = File.OpenRead(ImagingBase.PathToDataFiles + fileName);

            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string outPath = null; // Path to updated file (if this is empty, response contains streamed image)
            string storage = null; // We are using default Cloud Storage

            CreateModifiedJpeg2000Request postImageJpeg2000Request = new CreateModifiedJpeg2000Request(inputImageStream, comment, codec,
                                                                                        fromScratch, outPath, storage);

            Stream updatedImage = this.ImagingApi.CreateModifiedJpeg2000(postImageJpeg2000Request);
            
            // Save updated image to local storage
            using (var fileStream = File.Create(ImagingBase.PathToDataFiles + "Sample_out.jp2"))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }
        }
    }
}
