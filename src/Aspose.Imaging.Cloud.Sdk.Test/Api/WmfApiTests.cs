// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WmfApiTests.cs">
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
    ///  Class for testing WmfApi
    /// </summary>
    [TestFixture]
    public class WmfApiTests : ApiTester
    {
        /// <summary>
        /// Test GetImageWmf
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageWmfTest(bool saveResultToStorage)
        {
            string name = "test.wmf";
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
                "GetImageWmfTest",
                saveResultToStorage,
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeigth}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                outName,
                "Wmf",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageWmfRequest(name, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageWmf(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);
                    Assert.AreEqual(pageWidth + borderX * 2, resultProperties.Width);
                    Assert.AreEqual(pageHeigth + borderY * 2, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageWmf
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageWmfTest(bool saveResultToStorage)
        {
            string name = "test.wmf";
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
                "PostImageWmfTest",
                saveResultToStorage,
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeigth}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                outName,
                "Wmf",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageWmfRequest(inputStream, bkColor, pageWidth, pageHeigth, borderX, borderY,
                        fromScratch, outPath, storage);
                    return ImagingApi.PostImageWmf(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.PngProperties);
                    Assert.AreEqual(pageWidth + borderX * 2, resultProperties.Width);
                    Assert.AreEqual(pageHeigth + borderY * 2, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
