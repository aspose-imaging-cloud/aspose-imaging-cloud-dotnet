// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EmfApiTests.cs">
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
    ///  Class for testing EmfApi
    /// </summary>
    [TestFixture]
    public class EmfApiTests : ApiTester
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
        /// Test GetImageEmf
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageEmfTest(bool saveResultToStorage)
        {
            string name = "test.emf";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageEmfTest",
                saveResultToStorage,
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeigth}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                outName,
                "Emf",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageEmfRequest(name, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageEmf(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);
                    Assert.AreEqual(resultProperties.Width, (int)((pageWidth + borderX * 2) * (resultProperties.HorizontalResolution / 72)));
                    Assert.AreEqual(resultProperties.Height, (int)((pageHeigth + borderY * 2) * (resultProperties.VerticalResolution / 72)));
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageEmf
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageEmfTest(bool saveResultToStorage)
        {
            string name = "test.emf";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeigth = 300;
            int borderX = 50;
            int borderY = 50;
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageEmfTest",
                saveResultToStorage,
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeigth}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                outName,
                "Emf",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageEmfRequest(inputStream, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, outPath);
                    return ImagingApi.PostImageEmf(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);
                    Assert.AreEqual(resultProperties.Width, (int)((pageWidth + borderX * 2) * (resultProperties.HorizontalResolution / 72)));
                    Assert.AreEqual(resultProperties.Height, (int)((pageHeigth + borderY * 2) * (resultProperties.VerticalResolution / 72)));
                },
                folder,
                storage);
        }
    }
}
