// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JpgApiTests.cs">
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
    ///  Class for testing JpgApi
    /// </summary>
    [Category("v3.0")]
    [Category("Jpg")]
    [TestFixture]
    public class JpgApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test ModifyJpeg
        /// </summary>
        [Test]
        public void ModifyJpegTest()
        {
            string name = "test.jpg";
            int quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifyJpegTest",
                $"Input image: {name}; Quality: {quality}; Compression type: {compressionType}",
                name,
                delegate
                {
                    var request = new ModifyJpegRequest(name, quality, compressionType, fromScratch,
                        folder, storage);
                    return ImagingApi.ModifyJpeg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
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
        /// Test CreateModifiedJpeg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedJpegTest(bool saveResultToStorage)
        {
            string name = "test.jpg";
            int quality = 65;
            string compressionType = "progressive";
            bool? fromScratch = null;
            string outName = $"{name}_specific.jpg";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedJpegTest",
                saveResultToStorage,
                $"Input image: {name}; Quality: {quality}; Compression type: {compressionType}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedJpegRequest(inputStream, quality, compressionType, fromScratch, outPath, storage);
                    return ImagingApi.CreateModifiedJpeg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
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
