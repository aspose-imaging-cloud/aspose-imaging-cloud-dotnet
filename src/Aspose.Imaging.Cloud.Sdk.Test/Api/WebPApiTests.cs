// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WebPApiTests.cs">
//   Copyright (c) 2019 Aspose Pty Ltd. All rights reserved.
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
    [Category("v3.0")]
    [Category("Webp")]
    [TestFixture]
    public class WebPApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test ModifyWebP
        /// </summary>
        [Test]
        public void ModifyWebPTest()
        {
            string name = "Animation.webp";
            bool lossless = true;
            int quality = 90;
            int animLoopCount = 5;
            string animBackgroundColor = "gray";
            bool? fromScratch = null;
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifyWebPTest",
                $"Input image: {name}; AnimBackgroundColor: {animBackgroundColor}; Lossless: {lossless}; Quality: {quality}; AnimLoopCount: {animLoopCount}",
                name,
                delegate
                {
                    var request = new ModifyWebPRequest(name, lossless, quality, animLoopCount, 
                        animBackgroundColor, fromScratch, folder, storage);
                    return ImagingApi.ModifyWebP(request);
                },
                delegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(resultProperties.WebPProperties);

                    Assert.NotNull(originalProperties.WebPProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test CreateModifiedWebP
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedWebPTest(bool saveResultToStorage)
        {
            string name = "Animation.webp";
            bool lossless = true;
            int quality = 90;
            int animLoopCount = 5;
            string animBackgroundColor = "gray";
            bool? fromScratch = null;
            string outName = $"{name}_specific.webp";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedWebPTest",
                saveResultToStorage,
                $"Input image: {name}; AnimBackgroundColor: {animBackgroundColor}; Lossless: {lossless}; Quality: {quality}; AnimLoopCount: {animLoopCount}",
                name,
                outName,
                delegate(Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedWebPRequest(inputStream, lossless, quality, animLoopCount, animBackgroundColor, fromScratch, outPath, storage);
                    return ImagingApi.CreateModifiedWebP(request);
                },
                delegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(resultProperties.WebPProperties);

                    Assert.NotNull(originalProperties.WebPProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
