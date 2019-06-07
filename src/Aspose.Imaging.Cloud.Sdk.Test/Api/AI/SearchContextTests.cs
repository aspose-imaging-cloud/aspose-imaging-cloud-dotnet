// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FindImagesTests.cs">
//  Copyright (c) 2019 Aspose Pty Ltd. All rights reserved.
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Cloud.Sdk.Test.Api.AI
{
    using System.IO;
    using Client;
    using Model;
    using Model.Requests;
    using NUnit.Framework;

    [TestFixture]
    public class SearchContextTests : TestImagingAIBase
    {
        private const string SmallTestImage = "ComparableImage.jpg";
        private const string TestImage = "ComparingImageSimilar15.jpg";

        [Test]
        public void CreateSearchContextTest()
        {
            RunTestWithLogging("CreateSearchContextTest",
                  () => Assert.IsNotNull(this.SearchContextId));
        }

        [Test]
        public void DeleteImageSearchTest()
        {
            RunTestWithLogging("DeleteImageSearchTest",
                  () =>
                  {
                      this.DeleteImageSearch(this.SearchContextId);

                      Assert.Throws<ApiException>(() => this.ImagingApi.GetImageSearchStatus(
                          new GetImageSearchStatusRequest(this.SearchContextId, storage: this.TestStorage)));
                  });
        }

        [Test]
        public void AddImageTest()
        {
            RunTestWithLogging("AddImageTest",
               () => this.AddImage(TestImage));
        }

        [Test]
        public void DeleteImageTest()
        {
            RunTestWithLogging("DeleteImageTest",
                    () =>
                    {
                        var image = TestImage;
                        this.AddImage(image);

                        var destServerPath = $"{this.TempFolder}/{image}";

                        this.ImagingApi.DeleteSearchImage(
                            new DeleteSearchImageRequest(this.SearchContextId, destServerPath, storage: this.TestStorage));

                        Assert.Throws<ApiException>(() => this.ImagingApi.GetSearchImage(
                            new GetSearchImageRequest(this.SearchContextId, destServerPath, storage: this.TestStorage)));
                    });
        }

        [Test]
        public void GetImageTest()
        {
            RunTestWithLogging("GetImageTest",
                    () =>
                    {
                        var image = TestImage;
                        this.AddImage(image);
                        var responseStream = this.GetImage(image);
                        Assert.IsTrue((int)responseStream.Length > 50000);
                    });
        }

        [Test]
        public void UpdateImageTest()
        {
            RunTestWithLogging("UpdateImageTest",
                 () =>
                 {
                     var image = TestImage;
                     this.AddImage(image);
                     var responseStream = this.GetImage(image);
                     Assert.IsTrue(responseStream.Length > 50000);

                     image = SmallTestImage;
                     var destServerPath = $"{this.TempFolder}/{image}";

                     var storagePath = this.OriginalDataFolder + "/" + image;
                     var imageStream = this.ImagingApi.DownloadFile(new DownloadFileRequest(storagePath, this.TestStorage));
                     Assert.NotNull(imageStream);

                     this.ImagingApi.UpdateSearchImage(
                         new UpdateSearchImageRequest(this.SearchContextId, destServerPath, imageStream, storage: this.TestStorage));

                     responseStream = this.GetImage(image);
                     Assert.IsTrue((int)responseStream.Length < 40000);
                 });
        }

        [Test]
        public void ExtractImageFeaturesTest()
        {
            RunTestWithLogging("ExtractImageFeaturesTest",
                    () =>
                    {
                        var image = TestImage;

                        this.AddImage(image);

                        var destServerPath = $"{this.TempFolder}/{image}";

                        var response = this.ImagingApi.ExtractImageFeatures(
                            new ExtractImageFeaturesRequest(this.SearchContextId, destServerPath, storage: this.TestStorage));

                        Assert.IsTrue(response.ImageId.Contains(image));
                        Assert.IsTrue(response.Features.Length > 0);
                    });
        }

        [Test]
        public void ExtractAndAddImageFeaturesTest()
        {
            RunTestWithLogging("ExtractAndAddImageFeaturesTest",
                  () => this.AddImageFeatures(TestImage));
        }

        [Test]
        public void ExtractAndAddImageFeaturesFromFolderTest()
        {
            RunTestWithLogging("ExtractAndAddImageFeaturesFromFolderTest",
                    () =>
                    {
                        this.ImagingApi.CreateImageFeatures(
                            new CreateImageFeaturesRequest(
                                this.SearchContextId, null, null, $"{this.OriginalDataFolder}/FindSimilar", storage: this.TestStorage));

                        this.WaitSearchContextIdle();

                        var response = this.ImagingApi.GetImageFeatures(
                            new GetImageFeaturesRequest(this.SearchContextId, $"{this.OriginalDataFolder}/FindSimilar/3.jpg", storage: this.TestStorage));

                        Assert.IsTrue(response.ImageId.Contains("3.jp"));
                        Assert.IsTrue(response.Features.Length > 0);
                    });
        }

        [Test]
        public void GetImageFeaturesTest()
        {
            RunTestWithLogging("GetImageFeaturesTest",
                 () =>
                 {
                     this.AddImageFeatures(TestImage);
                     var response = this.GetImageFeatures(TestImage);
                     Assert.IsTrue(response.ImageId.Contains(TestImage));
                     var features = response.Features;
                     Assert.IsTrue(features.Length > 0);
                 });
        }

        [Test]
        public void DeleteImageFeaturesTest()
        {
            RunTestWithLogging("DeleteImageFeaturesTest",
                 () =>
                 {
                     var image = TestImage;
                     this.AddImageFeatures(image);
                     var destServerPath = $"{this.TempFolder}/{image}";
                     this.ImagingApi.DeleteSearchImage(
                         new DeleteSearchImageRequest(SearchContextId, destServerPath, storage: this.TestStorage));

                     Assert.Throws<ApiException>(() => this.ImagingApi.GetSearchImage(
                         new GetSearchImageRequest(this.SearchContextId, destServerPath, storage: this.TestStorage)));
                 });
        }

        [Test]
        public void UpdateImageFeaturesTest()
        {
            RunTestWithLogging("UpdateImageFeaturesTest",
                 () =>
                 {
                     var image = TestImage;
                     this.AddImageFeatures(image);
                     var response = this.GetImageFeatures(image);
                     Assert.IsTrue(response.ImageId.Contains(TestImage));
                     var features = response.Features;
                     var featuresLength = features.Length;

                     var destServerPath = $"{this.OriginalDataFolder}/{image}";

                     var storagePath = this.OriginalDataFolder + "/" + SmallTestImage;
                     var imageStream = this.ImagingApi.DownloadFile(new DownloadFileRequest(storagePath, this.TestStorage));
                     Assert.NotNull(imageStream);

                     this.ImagingApi.UpdateImageFeatures(
                         new UpdateImageFeaturesRequest(this.SearchContextId, destServerPath, imageStream, storage: this.TestStorage));

                     response = this.GetImageFeatures(image);
                     Assert.IsTrue(response.ImageId.Contains(TestImage));
                     Assert.IsTrue(featuresLength != response.Features.Length);
                 });
        }

        private void AddImage(string image)
        {
            var destServerPath = $"{this.TempFolder}/{image}";

            var storagePath = this.OriginalDataFolder + "/" + image;
            var imageStream = this.ImagingApi.DownloadFile(new DownloadFileRequest(storagePath, this.TestStorage));
            Assert.NotNull(imageStream);

            this.ImagingApi.AddSearchImage(
                new AddSearchImageRequest(this.SearchContextId, destServerPath, imageStream,
                    storage: this.TestStorage));

            var existResponse =
                this.ImagingApi.ObjectExists(new ObjectExistsRequest(destServerPath, this.TestStorage));
            Assert.IsNotNull(existResponse);
            Assert.IsTrue(existResponse.Exists == true);
        }

        private Stream GetImage(string image)
        {
            var destServerPath = $"{this.TempFolder}/{image}";
            var response = this.ImagingApi.GetSearchImage(
                new GetSearchImageRequest(this.SearchContextId, destServerPath, storage: this.TestStorage));
           
            return response;
        }

        private void AddImageFeatures(string image)
        {
            var destServerPath = $"{this.OriginalDataFolder}/{image}";

            this.ImagingApi.CreateImageFeatures(
                new CreateImageFeaturesRequest(this.SearchContextId, null, destServerPath, storage: this.TestStorage));
        }

        private ImageFeatures GetImageFeatures(string image)
        {
            var destServerPath = $"{this.OriginalDataFolder}/{image}";
            var response = this.ImagingApi.GetImageFeatures(
                new GetImageFeaturesRequest(this.SearchContextId, destServerPath, storage: this.TestStorage));

            return response;
        }
    }
}