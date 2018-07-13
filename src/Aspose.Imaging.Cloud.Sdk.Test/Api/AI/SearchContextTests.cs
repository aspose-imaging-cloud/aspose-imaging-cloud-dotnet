// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FindImagesTests.cs">
//  Copyright (c) 2018 Aspose Pty Ltd. All rights reserved.
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
    using System.Net;
    using Client;
    using Model;
    using Model.Requests;
    using NUnit.Framework;
    using Storage.Cloud.Sdk.Model.Requests;

    [TestFixture]
    public class SearchContextTests : TestImagingAIBase
    {
        private const string SmallTestImage = "ComparableImage.jpg";
        private const string TestImage = "ComparingImageSimilar15.jpg";

        [Test]
        public void CreateSearchContextTest()
        {
            Assert.IsNotNull(this.SearchContextId);
        }

        [Test]
        public void DeleteSearchContextTest()
        {
            this.DeleteSearchContext(this.SearchContextId);

            var errorMessage = Assert.Throws<ApiException>(() => this.ImagingApi.GetSearchContextStatus(
                new GetSearchContextStatusRequest(this.SearchContextId, storage: DefaultStorage))).Message;

            Assert.IsTrue(errorMessage.Contains("not found"));
        }

        [Test]
        public void AddImageTest()
        {
            var image = TestImage;

            this.AddImage(image);
        }

        [Test]
        public void DeleteImageTest()
        {
            var image = TestImage;
            this.AddImage(image);

            var destServerPath = $"{this.TempFolder}/{image}";

            this.ImagingApi.DeleteSearchContextImage(
                new DeleteSearchContextImageRequest(this.SearchContextId, destServerPath, storage: DefaultStorage));

            var errorMessage = Assert.Throws<ApiException>(() => this.ImagingApi.GetSearchContextImage(
                new GetSearchContextImageRequest(this.SearchContextId, destServerPath, storage: DefaultStorage))).Message;
            Assert.IsTrue(errorMessage.Contains("not found"));
        }

        [Test]
        public void GetImageTest()
        {
            var image = TestImage;
            this.AddImage(image);
            var responseStream = this.GetImage(image);
            Assert.IsTrue((int)responseStream.Length > 50000);
        }

        [Test]
        public void UpdateImageTest()
        {
            var image = TestImage;
            this.AddImage(image);
            var responseStream = this.GetImage(image);
            Assert.IsTrue(responseStream.Length > 50000);

            image = SmallTestImage;
            var destServerPath = $"{this.TempFolder}/{image}";

            var storagePath = this.OriginalDataFolder + "/" + image;
            var imageStream = this.StorageApi.GetDownload(new GetDownloadRequest(storagePath, null, DefaultStorage));
            Assert.NotNull(imageStream);

            this.ImagingApi.PutSearchContextImage(
                new PutSearchContextImageRequest(this.SearchContextId, destServerPath, imageStream, storage: DefaultStorage));

            responseStream = this.GetImage(image);
            Assert.IsTrue((int)responseStream.Length < 40000);
        }

        [Test]
        public void ExtractImageFeaturesTest()
        {
            var image = TestImage;

            this.AddImage(image);

            var destServerPath = $"{this.TempFolder}/{image}";

            var response = this.ImagingApi.GetSearchContextExtractImageFeatures(
                new GetSearchContextExtractImageFeaturesRequest(this.SearchContextId, destServerPath, storage: DefaultStorage));

            Assert.AreEqual(HttpStatusCode.OK, response.Code);
            Assert.IsTrue(response.ImageId.Contains(image));
            Assert.IsTrue(response.Features.Length > 0);
        }

        [Test]
        public void ExtractAndAddImageFeaturesTest()
        {
            this.AddImageFeatures(TestImage);
        }

        [Test]
        public void ExtractAndAddImageFeaturesFromFolderTest()
        {
            this.ImagingApi.PostSearchContextExtractImageFeatures(
                new PostSearchContextExtractImageFeaturesRequest(
                    this.SearchContextId, null, null, $"{this.OriginalDataFolder}/FindSimilar", DefaultStorage));

            var response = this.ImagingApi.GetSearchContextImageFeatures(
                new GetSearchContextImageFeaturesRequest(this.SearchContextId, $"{this.OriginalDataFolder}/FindSimilar/3.jpg", storage:DefaultStorage));

            Assert.AreEqual(HttpStatusCode.OK, response.Code);
            Assert.IsTrue(response.ImageId.Contains("3.jp"));
            Assert.IsTrue(response.Features.Length > 0);
        }

        [Test]
        public void GetImageFeaturesTest()
        {
             this.AddImageFeatures(TestImage);
            var response = this.GetImageFeatures(TestImage);
            Assert.IsTrue(response.ImageId.Contains(TestImage));
            var features = response.Features;
            Assert.IsTrue(features.Length > 0);
        }

        [Test]
        public void DeleteImageFeaturesTest()
        {
            var image = TestImage;
            this.AddImageFeatures(image);
            var destServerPath = $"{this.TempFolder}/{image}";
            this.ImagingApi.DeleteSearchContextImage(
                new DeleteSearchContextImageRequest(SearchContextId, destServerPath, storage: DefaultStorage));

            var errorMessage = Assert.Throws<ApiException>(() => this.ImagingApi.GetSearchContextImage(
                new GetSearchContextImageRequest(this.SearchContextId, destServerPath, storage: DefaultStorage))).Message;
            Assert.IsTrue(errorMessage.Contains("not found"));
        }

        [Test]
        public void UpdateImageFeaturesTest()
        {
            var image = TestImage;
            this.AddImageFeatures(image);
            var response = this.GetImageFeatures(image);
            Assert.IsTrue(response.ImageId.Contains(TestImage));
            var features = response.Features;
            var featuresLength = features.Length;

            var destServerPath = $"{this.OriginalDataFolder}/{image}";

            var storagePath = this.OriginalDataFolder + "/" + SmallTestImage;
            var imageStream = this.StorageApi.GetDownload(new GetDownloadRequest(storagePath, storage: DefaultStorage));
            Assert.NotNull(imageStream);

            this.ImagingApi.PutSearchContextImageFeatures(
                new PutSearchContextImageFeaturesRequest(this.SearchContextId, destServerPath, imageStream, storage: DefaultStorage));

            response = this.GetImageFeatures(image);
            Assert.IsTrue(response.ImageId.Contains(TestImage));
            Assert.IsTrue(featuresLength != response.Features.Length);
        }

        private void AddImage(string image)
        {
            var destServerPath = $"{this.TempFolder}/{image}";

            var storagePath = this.OriginalDataFolder + "/" + image;
            var imageStream = this.StorageApi.GetDownload(new GetDownloadRequest(storagePath, storage:DefaultStorage));
            Assert.NotNull(imageStream);

            this.ImagingApi.PostSearchContextAddImage(
                new PostSearchContextAddImageRequest(this.SearchContextId, destServerPath, imageStream, storage: DefaultStorage));
           
            var existResponse = this.StorageApi.GetIsExist(new GetIsExistRequest(destServerPath, storage: DefaultStorage));
            Assert.IsNotNull(existResponse);
            Assert.IsTrue(existResponse.FileExist.IsExist == true);
        }

        private Stream GetImage(string image)
        {
            var destServerPath = $"{this.TempFolder}/{image}";
            var response = this.ImagingApi.GetSearchContextImage(
                new GetSearchContextImageRequest(this.SearchContextId, destServerPath, storage: DefaultStorage));
           
            return response;
        }

        private void AddImageFeatures(string image)
        {
            var destServerPath = $"{this.OriginalDataFolder}/{image}";

            this.ImagingApi.PostSearchContextExtractImageFeatures(
                new PostSearchContextExtractImageFeaturesRequest(this.SearchContextId, null, destServerPath, storage: DefaultStorage));
        }

        private ImageFeatures GetImageFeatures(string image)
        {
            var destServerPath = $"{this.OriginalDataFolder}/{image}";
            var response = this.ImagingApi.GetSearchContextImageFeatures(
                new GetSearchContextImageFeaturesRequest(this.SearchContextId, destServerPath, storage: DefaultStorage));

            Assert.AreEqual(HttpStatusCode.OK, response.Code);
            return response;
        }
    }
}