// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WebPApiTests.cs">
//   Copyright (c) 2018 Aspose.Imaging for Cloud
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

namespace Aspose.Imaging.Cloud.Sdk.Test.Api
{
	using System.IO;
	using NUnit.Framework;

	using Aspose.Imaging.Cloud.Sdk.Model;
	using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing WebPApi
    /// </summary>
    [TestFixture]
    public class WebPApiTests : ApiTester
    {
        /// <summary>
        /// Test GetImageWebP
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageWebPTest(bool saveResultToStorage)
        {
            string name = "Animation.webp";
            bool lossless = true;
            int quality = 90;
            int animLoopCount = 5;
            string animBackgroundColor = "gray";
            bool? fromScratch = null;
            string outName = $"{name}_specific.webp";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageWebPTest",
                saveResultToStorage,
                $"Input image: {name}; AnimBackgroundColor: {animBackgroundColor}; Lossless: {lossless}; Quality: {quality}; AnimLoopCount: {animLoopCount}",
                name,
                outName,
                "Webp",
                delegate(string fileName, string outPath)
                {
                    var request = new GetImageWebPRequest(fileName, lossless, quality, animLoopCount, animBackgroundColor, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageWebP(request);
                },
                delegate(ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.WebPProperties);

                    /* TODO: uncomment after IMAGINGNET-2869 is done
                    Assert.AreEqual(lossless, resultProperties.WebPProperties.Lossless);
                    Assert.AreEqual(animLoopCount, resultProperties.WebPProperties.AnimLoopCount);
                    Assert.AreEqual(quality, (int) Math.Ceiling((double) resultProperties.WebPProperties.Quality));
                    */

                    Assert.NotNull(originalProperties.WebPProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageWebP
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageWebPTest(bool saveResultToStorage)
        {
            string name = "Animation.webp";
            bool lossless = true;
            int quality = 90;
            int animLoopCount = 5;
            string animBackgroundColor = "gray";
            bool? fromScratch = null;
            string outName = $"{name}_specific.webp";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageWebPTest",
                saveResultToStorage,
                $"Input image: {name}; AnimBackgroundColor: {animBackgroundColor}; Lossless: {lossless}; Quality: {quality}; AnimLoopCount: {animLoopCount}",
                name,
                outName,
                "Webp",
                delegate(Stream inputStream, string outPath)
                {
                    var request = new PostImageWebPRequest(inputStream, lossless, quality, animLoopCount, animBackgroundColor, fromScratch, outPath, storage);
                    return ImagingApi.PostImageWebP(request);
                },
                delegate(ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.WebPProperties);

                    /* TODO: uncomment after IMAGINGNET-2869 is done
                     Assert.AreEqual(lossless, resultProperties.WebPProperties.Lossless);
                    Assert.AreEqual(animLoopCount, resultProperties.WebPProperties.AnimLoopCount);
                    Assert.AreEqual(quality, (int) Math.Ceiling((double) resultProperties.WebPProperties.Quality));
                    */

                    Assert.NotNull(originalProperties.WebPProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
