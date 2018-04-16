// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BmpApiTests.cs">
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
	using System;
	using System.IO;
	using NUnit.Framework;

	using Aspose.Imaging.Cloud.Sdk.Model;
	using Aspose.Imaging.Cloud.Sdk.Model.Requests;
	
    /// <summary>
    ///  Class for testing BmpApi
    /// </summary>
    [TestFixture]
    public class BmpApiTests : ApiTester
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
        /// Test GetImageBmp
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageBmpTest(bool saveResultToStorage)
        {
            string name = "test.bmp";
            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            string outName = $"{name}_specific.bmp";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageBmpTest", 
                saveResultToStorage,
                $"Input image: {name}; Bits per pixel: {bitsPerPixel}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                outName,
                "Bmp",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageBmpRequest(fileName, bitsPerPixel, horizontalResolution, verticalResolution, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageBmp(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.BmpProperties);
                    Assert.AreEqual(resultProperties.BitsPerPixel, bitsPerPixel);
                    Assert.AreEqual((int)Math.Ceiling((double)resultProperties.VerticalResolution), verticalResolution);
                    Assert.AreEqual((int)Math.Ceiling((double)resultProperties.HorizontalResolution), horizontalResolution);

                    Assert.NotNull(originalProperties.BmpProperties);
                    Assert.AreEqual(originalProperties.BmpProperties.Compression, resultProperties.BmpProperties.Compression);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageBmp
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageBmpTest(bool saveResultToStorage)
        {
            string name = "test.bmp";
            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            string outName = $"{name}_specific.bmp";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageBmpTest",
                saveResultToStorage,
                $"Input image: {name}; Bits per pixel: {bitsPerPixel}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                outName,
                "Bmp",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageBmpRequest(inputStream, bitsPerPixel, horizontalResolution, verticalResolution, fromScratch, outPath);
                    return ImagingApi.PostImageBmp(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.BmpProperties);
                    Assert.AreEqual(resultProperties.BitsPerPixel, bitsPerPixel);
                    Assert.AreEqual((int)Math.Ceiling((double)resultProperties.VerticalResolution), verticalResolution);
                    Assert.AreEqual((int)Math.Ceiling((double)resultProperties.HorizontalResolution), horizontalResolution);

                    Assert.NotNull(originalProperties.BmpProperties);
                    Assert.AreEqual(originalProperties.BmpProperties.Compression, resultProperties.BmpProperties.Compression);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
