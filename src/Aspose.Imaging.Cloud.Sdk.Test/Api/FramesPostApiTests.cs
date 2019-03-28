// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FramesPostApiTests.cs">
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
    using NUnit.Framework;
    using System.IO;
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing FramesApi
    /// </summary>
    [Category("v3.0")]
    [Category("Tiff")]
    [TestFixture]
    public class FramesPostApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test PostImageFrame
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageSingleFrameTest(bool saveResultToStorage)
        {
            string name = "test.tiff";
            int? frameId = 2;
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            bool? saveOtherFrames = false;
            string folder = TempFolder;
            string storage = this.TestStorage;
            string outName = $"{name}_singleFrame.tiff";

            this.TestPostRequest(
                "GetImageSingleFrameTest",
                saveResultToStorage,
                $"Input image: {name}; Frame ID: {frameId}; New width: {newWidth}; New height: {newHeight}; Rotate/flip method: {rotateFlipMethod}; " +
                $"Save other frames: {saveOtherFrames}; X: {x}; Y: {y}; Rect width: {rectWidth}; Rect height: {rectHeight}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageFrameRequest(inputStream, frameId, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod,
                        saveOtherFrames, outPath, storage);
                    return ImagingApi.PostImageFrame(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(resultProperties.TiffProperties);
                    Assert.NotNull(resultProperties.TiffProperties.Frames);
                    Assert.AreEqual(1, resultProperties.TiffProperties.Frames.Count);

                    // please note that rotation was performed, so switching of width and height comparison is valid
                    Assert.AreEqual(rectHeight, resultProperties.TiffProperties.Frames[0].Width);
                    Assert.AreEqual(rectWidth, resultProperties.TiffProperties.Frames[0].Height);
                    Assert.AreEqual(resultProperties.TiffProperties.Frames[0].FrameOptions.ImageWidth, rectHeight);
                    Assert.AreEqual(rectWidth, resultProperties.TiffProperties.Frames[0].FrameOptions.ImageLength);
                    Assert.AreEqual(rectHeight, resultProperties.Width);
                    Assert.AreEqual(rectWidth, resultProperties.Height);

                    ImagingResponse framePropertiesResponse = null;
                    if (saveResultToStorage)
                    {
                        var framePropertiesRequest = new GetImageFramePropertiesRequest(outName, 0, folder, storage);
                        framePropertiesResponse = ImagingApi.GetImageFrameProperties(framePropertiesRequest);
                    }
                    else
                    {
                        resultStream.Seek(0, SeekOrigin.Begin);
                        var framePropertiesRequest = new PostImageFramePropertiesRequest(resultStream, 0);
                        framePropertiesResponse = ImagingApi.PostImageFrameProperties(framePropertiesRequest);
                    }

                    Assert.NotNull(framePropertiesResponse);
                    Assert.NotNull(framePropertiesResponse.TiffProperties);
                    Assert.NotNull(framePropertiesResponse.TiffProperties.Frames);
                    Assert.AreEqual(rectHeight, framePropertiesResponse.Width);
                    Assert.AreEqual(rectWidth, framePropertiesResponse.Height);
                    Assert.AreEqual(framePropertiesResponse.TiffProperties.Frames[0].Width, framePropertiesResponse.Width);
                    Assert.AreEqual(framePropertiesResponse.TiffProperties.Frames[0].Height, framePropertiesResponse.Height);
                    Assert.AreEqual(framePropertiesResponse.TiffProperties.Frames[0].FrameOptions.ImageWidth, framePropertiesResponse.Width);
                    Assert.AreEqual(framePropertiesResponse.TiffProperties.Frames[0].FrameOptions.ImageLength, framePropertiesResponse.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageFrame
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageAllFramesTest(bool saveResultToStorage)
        {
            string name = "test.tiff";
            int? frameId = 2;
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
            bool? saveOtherFrames = true;
            string folder = TempFolder;
            string storage = this.TestStorage;
            string outName = $"{name}_allFrames.tiff";

            this.TestPostRequest(
                "GetImageAllFramesTest",
                saveResultToStorage,
                $"Input image: {name}; Frame ID: {frameId}; New width: {newWidth}; New height: {newHeight}; Rotate/flip method: {rotateFlipMethod}; " +
                $"Save other frames: {saveOtherFrames}; X: {x}; Y: {y}; Rect width: {rectWidth}; Rect height: {rectHeight}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageFrameRequest(inputStream, frameId, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod,
                        saveOtherFrames, outPath, storage);
                    return ImagingApi.PostImageFrame(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(originalProperties);
                    Assert.NotNull(originalProperties.TiffProperties);
                    Assert.NotNull(originalProperties.TiffProperties.Frames);

                    Assert.NotNull(resultProperties);
                    Assert.NotNull(resultProperties.TiffProperties);
                    Assert.NotNull(resultProperties.TiffProperties.Frames);
                    Assert.AreEqual(originalProperties.TiffProperties.Frames.Count, resultProperties.TiffProperties.Frames.Count);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);

                    // please note that rotation was performed, so switching of width and height comparison is valid
                    Assert.AreEqual(rectHeight, resultProperties.TiffProperties.Frames[frameId.Value].Width);
                    Assert.AreEqual(rectWidth, resultProperties.TiffProperties.Frames[frameId.Value].Height);
                    Assert.AreEqual(rectHeight, resultProperties.TiffProperties.Frames[frameId.Value].FrameOptions.ImageWidth);
                    Assert.AreEqual(rectWidth, resultProperties.TiffProperties.Frames[frameId.Value].FrameOptions.ImageLength);
                },
                folder,
                storage);
        }
    }
}
