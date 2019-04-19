// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GifApiTests.cs">
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
    using System.Collections.Generic;
    using NUnit.Framework;

    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing GifApi
    /// </summary>
    [Category("v3.0")]
    [Category("Gif")]
    [TestFixture]
    public class GifApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test GetImageGif
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageGifTest(bool saveResultToStorage)
        {
            string name = "test.gif";
            int? backgroundColorIndex = 5;
            int? colorResolution = 4;
            bool hasTrailer = true;
            bool interlaced = false;
            bool isPaletteSorted = true;
            int pixelAspectRatio = 4;
            bool? fromScratch = null;
            string outName = $"{name}_specific.gif";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "GetImageGifTest",
                saveResultToStorage,
                $"Input image: {name}; Back color index: {backgroundColorIndex}; Color resolution: {colorResolution}; Has trailer: {hasTrailer}; " +
                $"Interlaced: {interlaced}; Is palette sorted: {isPaletteSorted}; Pixel aspect ratio: {pixelAspectRatio}",
                name,
                outName,
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageGifRequest(name, backgroundColorIndex, colorResolution, hasTrailer, interlaced, isPaletteSorted,
                        pixelAspectRatio, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageGif(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.GifProperties);

                    // TODO: enable when IMAGINGCLOUD-51 is done
                    //Assert.AreEqual(hasTrailer, resultProperties.GifProperties.HasTrailer);
                    Assert.AreEqual(pixelAspectRatio, resultProperties.GifProperties.PixelAspectRatio);

                    Assert.IsNotNull(originalProperties.GifProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageGif
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageGifTest(bool saveResultToStorage)
        {
            string name = "test.gif";
            int? backgroundColorIndex = 5;
            int? colorResolution = 4;
            bool hasTrailer = true;
            bool interlaced = false;
            bool isPaletteSorted = true;
            int pixelAspectRatio = 4;
            bool? fromScratch = null;
            string outName = $"{name}_specific.gif";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "PostImageGifTest",
                saveResultToStorage,
                $"Input image: {name}; Back color index: {backgroundColorIndex}; Color resolution: {colorResolution}; Has trailer: {hasTrailer}; " +
                $"Interlaced: {interlaced}; Is palette sorted: {isPaletteSorted}; Pixel aspect ratio: {pixelAspectRatio}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageGifRequest(inputStream, backgroundColorIndex, colorResolution, hasTrailer, interlaced, isPaletteSorted,
                        pixelAspectRatio, fromScratch, outPath, storage);
                    return ImagingApi.PostImageGif(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.GifProperties);

                    // TODO: enable when IMAGINGCLOUD-51 is done
                    //Assert.AreEqual(hasTrailer, resultProperties.GifProperties.HasTrailer);
                    Assert.AreEqual(pixelAspectRatio, resultProperties.GifProperties.PixelAspectRatio);

                    Assert.IsNotNull(originalProperties.GifProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
