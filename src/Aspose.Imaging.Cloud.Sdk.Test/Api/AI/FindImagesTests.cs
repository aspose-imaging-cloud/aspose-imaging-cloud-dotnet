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
    using System.Net;
    using Model.Requests;
    using Newtonsoft.Json;
    using NUnit.Framework;
    using Storage.Cloud.Sdk.Model.Requests;

    [TestFixture]
    public class FindImagesTests : TestImagingAIBase
    {
        private const string ImageToFind = "4.jpg";
        private const string ImageToFindByTag = "ComparingImageSimilar75.jpg";

        [Test]
        public void FindSimilarImagesTest()
        {
            RunTestWithLogging("FindSimilarImagesTest",
                () =>
                {
                    this.AddImageFeaturesToSearchContext($"{this.OriginalDataFolder}/FindSimilar", true);
                    var findImageId = $"{this.OriginalDataFolder}/FindSimilar/{ImageToFind}";
                    var response = this.ImagingApi.GetSearchContextFindSimilar(
                        new GetSearchContextFindSimilarRequest(this.SearchContextId, 3, 3, imageId: findImageId, storage: this.TestStorage));

                    Assert.AreEqual(HttpStatusCode.OK, response.Code);
                    Assert.IsTrue(response.Results.Count >= 1);
                });
        }

        [Test]
        public void FindSimilarImagesByTagTest()
        {
            RunTestWithLogging("FindSimilarImagesByTagTest",
                 () =>
                 {
                     this.AddImageFeaturesToSearchContext($"{this.OriginalDataFolder}/FindSimilar", true);

                     var tag = "TestTag";

                     var storagePath = this.OriginalDataFolder + "/" + ImageToFindByTag;

                     var tagImageStream = this.StorageApi.GetDownload(new GetDownloadRequest(storagePath, null, this.TestStorage));
                     Assert.NotNull(tagImageStream);
                     this.ImagingApi.PostSearchContextAddTag(
                         new PostSearchContextAddTagRequest(tagImageStream, this.SearchContextId, tag, storage: this.TestStorage));

                     var tags = JsonConvert.SerializeObject(new[] { tag });
                     var response = this.ImagingApi.PostSearchContextFindByTags(
                         new PostSearchContextFindByTagsRequest(tags, this.SearchContextId, 60, 5, storage: this.TestStorage));
                     Assert.AreEqual(HttpStatusCode.OK, response.Code);
                     Assert.AreEqual(1, response.Results.Count);
                     Assert.IsTrue(response.Results[0].ImageId.Contains("2.jpg"));
                 });
        }
    }
}