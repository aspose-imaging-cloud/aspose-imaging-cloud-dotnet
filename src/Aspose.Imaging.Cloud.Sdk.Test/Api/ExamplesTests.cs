//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExamplesTests.cs" company="Aspose Pty Ltd." author="Maksym Shnurenok" date="04.04.2019 16:50:26">
//    Copyright (c) 2001-2019 Aspose Pty Ltd.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;

    using System.IO;
    using Aspose.Imaging.Cloud.Sdk.Api;
    using Aspose.Imaging.Cloud.Sdk.Test.Base;
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    /// Tests that correspond with examples code.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Test.Base.ApiTester" />
    [Category("v3.0")]
    [Category("Examples")]
    [TestFixture]
    public class ExamplesTests : ApiTester
    {
        /// <summary>
        /// Convert from storage example test.
        /// </summary>
        [Test]
        public void ConvertFromStorageExampleTest()
        {
            var config = this.ImagingApi.Configuration;
            var imagingApi = config.OnPremise ? new ImagingApi(config.ApiBaseUrl, config.ApiVersion, config.DebugMode) 
                : new ImagingApi(config.ClientSecret, config.ClientId, config.ApiBaseUrl);

            try
            {
                // upload local image to storage
                using (FileStream localInputImage = File.OpenRead(Path.Combine(LocalTestFolder, "test.png")))
                {
                    var uploadFileRequest =
                        new UploadFileRequest("ExampleFolderNet/inputImage.png", localInputImage,
                            config.OnPremise ? this.TestStorage : null);
                    FilesUploadResult result = imagingApi.UploadFile(uploadFileRequest);
                    // inspect result.Errors list if there were any
                    // inspect result.Uploaded list for uploaded file names
                }

                // convert image from storage to JPEG
                var getConvertRequest =
                    new ConvertImageRequest("inputImage.png", "jpg", "ExampleFolderNet",
                        config.OnPremise ? this.TestStorage : null);

                using (Stream convertedImage = imagingApi.ConvertImage(getConvertRequest))
                {
                    // process resulting image
                    // for example, save it to storage
                    var uploadFileRequest =
                        new UploadFileRequest("ExampleFolderNet/resultImage.jpg", convertedImage, 
                            config.OnPremise ? this.TestStorage : null);
                    FilesUploadResult result = imagingApi.UploadFile(uploadFileRequest);
                    // inspect result.Errors list if there were any
                    // inspect result.Uploaded list for uploaded file names
                }
            }
            finally
            {
                // remove files from storage
                imagingApi.DeleteFile(new DeleteFileRequest("ExampleFolderNet/inputImage.png", 
                    config.OnPremise ? this.TestStorage : null));
                imagingApi.DeleteFile(new DeleteFileRequest("ExampleFolderNet/resultImage.jpg", 
                    config.OnPremise ? this.TestStorage : null));
            }
        }

        /// <summary>
        /// Convert from stream example test.
        /// </summary>
        [Test]
        public void ConvertFromStreamExampleTest()
        {
            var config = this.ImagingApi.Configuration;
            var imagingApi = config.OnPremise ? new ImagingApi(config.ApiBaseUrl, config.ApiVersion, config.DebugMode)
                : new ImagingApi(config.ClientSecret, config.ClientId, config.ApiBaseUrl);

            try
            {
                // get local image stream
                using (FileStream localInputImage = File.OpenRead(Path.Combine(LocalTestFolder, "test.png")))
                {
                    // convert image from request stream to JPEG and save it to storage
                    // please, use outPath parameter for saving the result to storage
                    var postSaveToStorageRequest =
                        new CreateConvertedImageRequest(localInputImage, "jpg", "ExampleFolderNet/resultImage.jpg",
                            config.OnPremise ? this.TestStorage : null);

                    imagingApi.CreateConvertedImage(postSaveToStorageRequest);

                    // download saved image from storage
                    using (Stream savedFile =
                        imagingApi.DownloadFile(new DownloadFileRequest("ExampleFolderNet/resultImage.jpg",
                            config.OnPremise ? this.TestStorage : null)))
                    {
                        // process resulting image from storage
                    }

                    localInputImage.Seek(0, SeekOrigin.Begin);

                    // convert image from request stream to JPEG and read it from resulting stream
                    // please, set outPath parameter as null to return result in request stream instead of saving to storage
                    var postSaveToStreamRequest =
                        new CreateConvertedImageRequest(localInputImage, "jpg", null, 
                            config.OnPremise ? this.TestStorage : null);

                    using (Stream resultPostImageStream = imagingApi.CreateConvertedImage(postSaveToStreamRequest))
                    {
                        // process resulting image from response stream
                    }
                }
            }
            finally
            {
                // remove file from storage
                imagingApi.DeleteFile(new DeleteFileRequest("ExampleFolderNet/resultImage.jpg",
                    config.OnPremise ? this.TestStorage : null));
            }
        }
    }
}
