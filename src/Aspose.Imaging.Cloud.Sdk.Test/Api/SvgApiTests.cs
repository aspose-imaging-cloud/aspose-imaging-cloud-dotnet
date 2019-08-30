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
        /// Test ModifySvg performing rasterization of image using page size parameters
        /// </summary>
        [Test]
        public void ModifySvgSizeRasterizationTest()
        {
            string name = "test.svg";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeight = 300;
            // borderX and borderY are not supported right now, see IMAGINGNET-3543
            int borderX = 0;
            int borderY = 0;
            var format = "png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifySvgTest",
                $"Input image: {name}; BackColor: {bkColor}; Page width: {pageWidth}; Page height: {pageHeight}; BorderX: {borderX}; BorderY: {borderY}",
                name,
                delegate
                {
                    var request = new ModifySvgRequest(name, pageWidth: pageWidth, pageHeight: pageHeight, borderX: borderX, borderY: borderY,
                        bkColor: bkColor, folder: folder, storage: storage, format: format);
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
        /// Test ModifySvg performing rasterization of image using scale parameters
        /// </summary>
        [Test]
        public void ModifySvgScaleRasterizationTest()
        {
            string name = "test.svg";
            string bkColor = "gray";
            int scaleX = 2;
            int scaleY = 2;
            var format = "png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifySvgTest",
                $"Input image: {name}; BackColor: {bkColor}; Scale X: {scaleX}; Scale Y: {scaleY}",
                name,
                delegate
                {
                    var request = new ModifySvgRequest(name, scaleX: scaleX, scaleY: scaleY, bkColor: bkColor,
                        folder: folder, storage: storage, format: format);
                    return ImagingApi.ModifySvg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    var width = originalProperties.Width * scaleX;
                    var height = originalProperties.Height * scaleY;
                    Assert.IsNotNull(resultProperties.PngProperties);
                    Assert.AreEqual(width, resultProperties.Width);
                    Assert.AreEqual(height, resultProperties.Height);
                },
                folder,
                storage);
        }
        
        /// <summary>
        /// Test ModifySvg performing update of image properties
        /// </summary>
        [Test]
        public void ModifySvgUpdatePropertiesTest()
        {
            string name = "test.svg";
            // Only RGB color type is supported right now, see IMAGINGNET-3543
            var colorType = "rgb";
            var textAsShapes = true;
            var format = "svg";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifySvgTest",
                $"Input image: {name}; Color type: {colorType}; Text as shapes: {textAsShapes}",
                name,
                delegate
                {
                    var request = new ModifySvgRequest(name, colorType, textAsShapes,
                        folder: folder, storage: storage, format: format);
                    return ImagingApi.ModifySvg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.SvgProperties);
                    Assert.AreEqual(colorType.ToLowerInvariant(),
                        resultProperties.SvgProperties.ColorType.ToLowerInvariant());
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test ModifySvg performing rasterization of image using page size parameters
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedSvgSizeRasterizationTest(bool saveResultToStorage)
        {
            string name = "test.svg";
            string bkColor = "gray";
            int pageWidth = 300;
            int pageHeight = 300;
            // borderX and borderY are not supported right now, see IMAGINGNET-3543
            int borderX = 0;
            int borderY = 0;
            var format = "png";
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
                    var request = new CreateModifiedSvgRequest(inputStream, pageWidth: pageWidth, pageHeight: pageHeight, borderX: borderX, borderY: borderY,
                        bkColor: bkColor, outPath: outPath, storage: storage, format: format);
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
        
        /// <summary>
        /// Test ModifySvg performing rasterization of image using scale parameters
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedSvgScaleRasterizationTest(bool saveResultToStorage)
        {
            string name = "test.svg";
            string bkColor = "gray";
            int scaleX = 2;
            int scaleY = 2;
            var format = "png";
            string outName = $"{name}_specific.png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedSvgTest",
                saveResultToStorage,
                $"Input image: {name}; BackColor: {bkColor}; Scale X: {scaleX}; Scale Y: {scaleY}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedSvgRequest(inputStream, scaleX: scaleX, scaleY: scaleY,
                        bkColor: bkColor, outPath: outPath, storage: storage, format: format);
                    return ImagingApi.CreateModifiedSvg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    var width = originalProperties.Width * scaleX;
                    var height = originalProperties.Height * scaleY;
                    Assert.IsNotNull(resultProperties.PngProperties);
                    Assert.AreEqual(width, resultProperties.Width);
                    Assert.AreEqual(height, resultProperties.Height);
                },
                folder,
                storage);
        }
        
        /// <summary>
        /// Test ModifySvg performing update of image properties
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedSvgUpdatePropertiesTest(bool saveResultToStorage)
        {
            string name = "test.svg";
            // Only RGB color type is supported right now, see IMAGINGNET-3543
            var colorType = "rgb";
            var textAsShapes = true;
            var format = "svg";
            string outName = $"{name}_specific.png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedSvgTest",
                saveResultToStorage,
                $"Input image: {name}; Color type: {colorType}; Text as shapes: {textAsShapes}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedSvgRequest(inputStream, colorType,
                        textAsShapes: textAsShapes, outPath: outPath, storage: storage, format: format);
                    return ImagingApi.CreateModifiedSvg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.SvgProperties);
                    Assert.AreEqual(colorType.ToLowerInvariant(),
                        resultProperties.SvgProperties.ColorType.ToLowerInvariant());
                },
                folder,
                storage);
        }
    }
}
