using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.Imaging.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Api;

namespace Aspose.Imaging.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// Aspose.HTML Cloud API convert method to convert word document file to other format
    ///</Summary>

    public class AsposeImagingConversion : AsposeImagingCloudBase
    {
        ///<Summary>
        /// Convert method to convert file to other format
        ///</Summary>
        public Response Convert(string fileName, string folderName, string outputType)
        {
            ImagingApi imagingApi = new ImagingApi(Config.Configuration.AppKey, Config.Configuration.AppSID, "https://api.aspose.cloud/");

            string filenamepath = Config.Configuration.WorkingDirectory + folderName + "\\"+ fileName;

            // Upload local image to Cloud Storage
            using (FileStream localInputImage = File.OpenRead(filenamepath))
            {
                var uploadFileRequest = new UploadFileRequest(fileName, localInputImage);
                FilesUploadResult result = imagingApi.UploadFile(uploadFileRequest);
            }

            // Please refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats
            // for possible output formats
            string format = outputType.ToLower();
            string folder = null; // Input file is saved at the root of the storage
            string storage = null; // Cloud Storage name

            var request = new ConvertImageRequest(fileName, format, folder, storage);
            Stream updatedImage = imagingApi.ConvertImage(request);

            updatedImage.Position = 0;
            string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(filenamepath);
            string outputFileName = fileNamewithOutExtension + "." + outputType;

            Aspose.Storage.Cloud.Sdk.Model.Requests.PutCreateRequest putCreateRequest = new Aspose.Storage.Cloud.Sdk.Model.Requests.PutCreateRequest(outputFileName, updatedImage, null, null);
            storageApi.PutCreate(putCreateRequest);

            bool foundSaveOption = true;

            if (outputType == "pdf")
            {
            }
            else
            {
                foundSaveOption = false;
            }

            if (foundSaveOption)
            {

                return new Response
                {
                    FileName = outputFileName,
                    Status = "OK",
                    StatusCode = 200,
                };
            }
            
            return new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };

        }

    }
}
