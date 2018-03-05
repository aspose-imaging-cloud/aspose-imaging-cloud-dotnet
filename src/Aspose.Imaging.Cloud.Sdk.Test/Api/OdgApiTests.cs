// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OdgApiTests.cs">
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
    ///  Class for testing OdgApi
    /// </summary>
    [TestFixture]
    public class OdgApiTests : ApiTester
    {
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
			// you can pass your own parameters here
            this.CreateApiInstances();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test GetImageOdg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageOdgTest(bool saveResultToStorage)
        {
            string name = "test.odg";
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageOdgTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                "Odg",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageOdgRequest(fileName, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageOdg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);

                    Assert.AreEqual(resultProperties.Width, originalProperties.Width + 1);
                    Assert.AreEqual(resultProperties.Height, originalProperties.Height + 1);
                    Assert.NotNull(originalProperties.OdgProperties);
                    Assert.NotNull(originalProperties.OdgProperties.Pages);
                    Assert.AreEqual(originalProperties.OdgProperties.PageCount, 2);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Width, originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Height, originalProperties.Height);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Width, originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Height, originalProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageOdg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageOdgTest(bool saveResultToStorage)
        {
            string name = "test.odg";
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageOdgTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                "Odg",
                delegate (Stream inpuStream, string outPath)
                {
                    var request = new PostImageOdgRequest(inpuStream, fromScratch, outPath);
                    return ImagingApi.PostImageOdg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);

                    Assert.AreEqual(resultProperties.Width, originalProperties.Width + 1);
                    Assert.AreEqual(resultProperties.Height, originalProperties.Height + 1);
                    Assert.NotNull(originalProperties.OdgProperties);
                    Assert.NotNull(originalProperties.OdgProperties.Pages);
                    Assert.AreEqual(originalProperties.OdgProperties.PageCount, 2);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Width, originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Height, originalProperties.Height);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Width, originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Height, originalProperties.Height);
                },
                folder,
                storage);
        }
    }
}
