// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SvgApiTests.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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
    ///  Class for testing SvgApi
    /// </summary>
    [Category("v3.0")]
    [Category("Svg")]
    [TestFixture]
    public class SvgApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test ModifySvg
        /// </summary>
        [Test]
        public void ModifySvgTest()
        {
            string name = "test.svg";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeight = 300;
            int borderX = 50;
            int borderY = 50;
            bool? fromScratch = null;
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifySvgTest",
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeight}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                delegate
                {
                    var request = new ModifySvgRequest(name, bkColor, pageWidth, pageHeight, borderX, borderY,
                        fromScratch, folder, storage);
                    return ImagingApi.ModifySvg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    int width = pageWidth + borderX * 2;
                    int height = pageHeight + borderY * 2;
                    Assert.IsNotNull(resultProperties.PngProperties);
                    Assert.AreEqual(width, resultProperties.Width);
                    Assert.AreEqual(height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test CreateModifiedSvg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedSvgTest(bool saveResultToStorage)
        {
            string name = "test.svg";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeight = 300;
            int borderX = 50;
            int borderY = 50;
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedSvgTest",
                saveResultToStorage,
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeight}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedSvgRequest(inputStream, bkColor, pageWidth, pageHeight, borderX, borderY,
                        fromScratch, outPath, storage);
                    return ImagingApi.CreateModifiedSvg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    int width = pageWidth + borderX * 2;
                    int height = pageHeight + borderY * 2;
                    Assert.IsNotNull(resultProperties.PngProperties);
                    Assert.AreEqual(width, resultProperties.Width);
                    Assert.AreEqual(height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
