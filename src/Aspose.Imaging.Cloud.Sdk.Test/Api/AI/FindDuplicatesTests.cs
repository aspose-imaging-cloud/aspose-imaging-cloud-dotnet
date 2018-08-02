// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FindDuplicatesTests.cs">
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

    [TestFixture]
    public class FindDuplicatesTests : TestImagingAIBase
    {
        private const string ComparableImage = "ComparableImage.jpg";
        private const string ComparingImageSimilarLess15 = "ComparingImageSimilar15.jpg";
        private const string ComparingImageSimilarMore75 = "ComparingImageSimilar75.jpg";

        [Test]
        public void FindDuplicatesTest()
        {
            RunTestWithLogging("FindDuplicatesTest",
                  () =>
                  {
                      this.AddImageFeaturesToSearchContext($"{this.OriginalDataFolder}/FindSimilar", true);

                      var image = this.GetStoragePath(ComparableImage);
                      this.AddImageFeaturesToSearchContext(image);

                      image = this.GetStoragePath(ComparingImageSimilarLess15);
                      this.AddImageFeaturesToSearchContext(image);

                      image = this.GetStoragePath(ComparingImageSimilarMore75);
                      this.AddImageFeaturesToSearchContext(image);

                      var response = this.ImagingApi.GetSearchContextFindDuplicates(
                          new GetSearchContextFindDuplicatesRequest(this.SearchContextId, 80));
                      Assert.AreEqual(HttpStatusCode.OK, response.Code);
                      Assert.AreEqual(1, response.Duplicates.Count);
                  });
        }
    }
}