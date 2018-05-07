// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PngApiTests.cs">
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
    ///  Class for testing PngApi
    /// </summary>
    [TestFixture]
    public class PngApiTests : ApiTester
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
        /// Test GetImagePng
        /// TODO: when IMAGINGCLOUD-48 is done, test should be improved with new options
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImagePngTest(bool saveResultToStorage)
        {
            string name = "test.png";
            bool? fromScratch = false;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImagePngTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                "Png",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImagePngRequest(fileName, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImagePng(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);

                    Assert.NotNull(originalProperties.PngProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);

                    // this should be uncommented when IMAGINGCLOUD-48 is done
                    //Assert.AreEqual(originalProperties.BitsPerPixel, resultProperties.BitsPerPixel);
                    Assert.AreEqual(originalProperties.HorizontalResolution, resultProperties.HorizontalResolution);
                    Assert.AreEqual(originalProperties.VerticalResolution, resultProperties.VerticalResolution);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImagePng
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImagePngTest(bool saveResultToStorage)
        {
            string name = "test.png";
            bool? fromScratch = false;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImagePngTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                "Png",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImagePngRequest(inputStream, fromScratch, outPath, storage);
                    return ImagingApi.PostImagePng(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);

                    Assert.NotNull(originalProperties.PngProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);

                    // this should be uncommented when IMAGINGCLOUD-48 is done
                    //Assert.AreEqual(originalProperties.BitsPerPixel, resultProperties.BitsPerPixel);
                    Assert.AreEqual(originalProperties.HorizontalResolution, resultProperties.HorizontalResolution);
                    Assert.AreEqual(originalProperties.VerticalResolution, resultProperties.VerticalResolution);
                },
                folder,
                storage);
        }
    }
}
