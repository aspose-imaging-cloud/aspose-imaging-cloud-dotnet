// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CompareImagesTests.cs">
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
    using System.Net;
    using Model.Requests;
    using NUnit.Framework;
    using Storage.Cloud.Sdk.Model.Requests;

    [TestFixture]
    public class CompareImagesTests : TestImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        [Test]
        public void CompareTwoImagesInSearchContextTest()
        {
            RunTestWithLogging("CompareTwoImagesInSearchContextTest",
                () =>
                {
                    var image1 = this.GetStoragePath(ComparableImage);
                    this.AddImageFeaturesToSearchContext(image1);

                    var image2 = this.GetStoragePath(ComparingImageSimilarMore75);
                    this.AddImageFeaturesToSearchContext(image2);

                    var response = this.ImagingApi.PostSearchContextCompareImages(
                        new PostSearchContextCompareImagesRequest(this.SearchContextId, image1, null, image2, storage: this.TestStorage));

                    Assert.AreEqual(1, response.Results.Count);
                    Assert.IsTrue(response.Results[0].Similarity >= 70);
                });
        }

        [Test]
        public void CompareLoadedImageToImageInSearchContextTest()
        {
            RunTestWithLogging("CompareLoadedImageToImageInSearchContextTest",
                  () =>
                  {
                      var image = this.GetStoragePath(ComparableImage);
                      this.AddImageFeaturesToSearchContext(image);

                      var storagePath = this.OriginalDataFolder + "/" + ComparingImageSimilarLess15;

                      var imageStream = this.StorageApi.GetDownload(new GetDownloadRequest(storagePath, null, this.TestStorage));
                      Assert.NotNull(imageStream);

                      var response = this.ImagingApi.PostSearchContextCompareImages(
                          new PostSearchContextCompareImagesRequest(this.SearchContextId, image, imageStream, storage: this.TestStorage));

                      Assert.AreEqual(HttpStatusCode.OK, response.Code);
                      Assert.AreEqual(1, response.Results.Count);
                      Assert.IsTrue(response.Results[0].Similarity <= 15);
                  });
        }
    }
}