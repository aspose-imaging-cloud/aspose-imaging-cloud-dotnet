using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Aspose.Imaging.Cloud.Live.Demos.Services
{
    public interface IAsposeImagingCloudApiService
    {
        Stream Convert(Stream file, string fileName, string toFormat);
    }

    public class AsposeImagingCloudApiService : IAsposeImagingCloudApiService
    {
        public readonly ImagingApi ImagingCloudApi;

        public AsposeImagingCloudApiService(IConfiguration config)
        {
            string ClientId = config["AsposeImagingUserData:ClientId"];
            string ClientSecret = config["AsposeImagingUserData:ClientSecret"];

            ImagingCloudApi = new ImagingApi(clientSecret: ClientSecret, clientId: ClientId);
        }

        public Stream Convert(Stream file, string fileName, string toFormat)
        {
            UploadFileRequest uploadFileRequest = new UploadFileRequest()
            {
                path = fileName,
                File = file
            };

            ImagingCloudApi.UploadFile(uploadFileRequest);

            var request = new ConvertImageRequest()
            {
                name = fileName,
                format = toFormat
            };

            var convertResult = ImagingCloudApi.ConvertImage(request);

            DeleteFileRequest deleteFileRequest = new DeleteFileRequest()
            {
                path = fileName
            };

            ImagingCloudApi.DeleteFile(deleteFileRequest);

            return convertResult;
        }
    }
}
