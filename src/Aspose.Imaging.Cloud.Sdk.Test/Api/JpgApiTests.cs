// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JpgApiTests.cs">
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
    ///  Class for testing JpgApi
    /// </summary>
    [TestFixture]
    public class JpgApiTests : ApiTester
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
        /// Test GetImageJpg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageJpgTest(bool saveResultToStorage)
        {
            string name = "test.jpg";
            int quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string outName = $"{name}_specific.jpg";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageJpgTest",
                saveResultToStorage,
                $"Input image: {name}; Quality: {quality}; Compression type: {compressionType}",
                name,
                outName,
                "Jpg",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageJpgRequest(name, quality, compressionType, fromScratch, outPath,
                        folder, storage);
                    return ImagingApi.GetImageJpg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.JpegProperties);

                    Assert.NotNull(originalProperties.JpegProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageJpg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageJpgTest(bool saveResultToStorage)
        {
            string name = "test.jpg";
            int quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string outName = $"{name}_specific.jpg";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageJpgTest",
                saveResultToStorage,
                $"Input image: {name}; Quality: {quality}; Compression type: {compressionType}",
                name,
                outName,
                "Jpg",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageJpgRequest(inputStream, quality, compressionType, fromScratch, outPath, storage);
                    return ImagingApi.PostImageJpg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.JpegProperties);

                    Assert.NotNull(originalProperties.JpegProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
