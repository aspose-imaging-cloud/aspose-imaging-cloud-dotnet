// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BmpApiTests.cs">
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
    using System;
    using System.IO;
    using NUnit.Framework;

    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing BmpApi
    /// </summary>
    [Category("v3.0")]
    [Category("Bmp")]
    [TestFixture]
    public class BmpApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test ModifyBmp
        /// </summary>
        [Test]
        public void ModifyBmpTest()
        {
            string name = "test.bmp";
            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifyBmpTest", 
                $"Input image: {name}; Bits per pixel: {bitsPerPixel}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                delegate
                {
                    var request = new ModifyBmpRequest(name, bitsPerPixel, horizontalResolution, verticalResolution, 
                        fromScratch, folder, storage);
                    return ImagingApi.ModifyBmp(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.BmpProperties);
                    Assert.AreEqual(bitsPerPixel, resultProperties.BitsPerPixel);
                    Assert.AreEqual(verticalResolution, (int)Math.Ceiling((double)resultProperties.VerticalResolution));
                    Assert.AreEqual(horizontalResolution, (int)Math.Ceiling((double)resultProperties.HorizontalResolution));

                    Assert.IsNotNull(originalProperties.BmpProperties);
                    Assert.AreEqual(originalProperties.BmpProperties.Compression,
                        resultProperties.BmpProperties.Compression);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test CreateModifiedBmp
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedBmpTest(bool saveResultToStorage)
        {
            string name = "test.bmp";
            int? bitsPerPixel = 32;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            bool? fromScratch = null;
            string outName = $"{name}_specific.bmp";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedBmpTest",
                saveResultToStorage,
                $"Input image: {name}; Bits per pixel: {bitsPerPixel}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedBmpRequest(inputStream, bitsPerPixel, horizontalResolution, verticalResolution, fromScratch, outPath, storage);
                    return ImagingApi.CreateModifiedBmp(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.BmpProperties);
                    Assert.AreEqual(bitsPerPixel, resultProperties.BitsPerPixel);
                    Assert.AreEqual(verticalResolution, (int)Math.Ceiling((double)resultProperties.VerticalResolution));
                    Assert.AreEqual(horizontalResolution, (int)Math.Ceiling((double)resultProperties.HorizontalResolution));

                    Assert.IsNotNull(originalProperties.BmpProperties);
                    Assert.AreEqual(originalProperties.BmpProperties.Compression,
                        resultProperties.BmpProperties.Compression);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }
    }
}
