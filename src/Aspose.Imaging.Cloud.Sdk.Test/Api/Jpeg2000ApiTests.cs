// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Jpeg2000ApiTests.cs">
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
    using NUnit.Framework;

    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing Jpeg2000Api
    /// </summary>
    [Category("v3.0")]
    [Category("Jpeg2000")]
    [TestFixture]
    public class Jpeg2000ApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test ModifyJpeg2000
        /// </summary>
        [Test]
        public void ModifyJpeg2000Test()
        {
            string name = "test.j2k";
            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "ModifyJpeg2000Test",
                $"Input image: {name}; Comment: {comment}; Codec: {codec}",
                name,
                delegate
                {
                    var request = new ModifyJpeg2000Request(name, comment, codec, fromScratch, folder, storage);
                    return ImagingApi.ModifyJpeg2000(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.Jpeg2000Properties);

                    Assert.IsNotNull(resultProperties.Jpeg2000Properties.Codec);
                    Assert.AreEqual(codec, resultProperties.Jpeg2000Properties.Codec.ToString().ToLower());
                    Assert.IsNotNull(resultProperties.Jpeg2000Properties.Comments);
                    Assert.AreEqual(comment, resultProperties.Jpeg2000Properties.Comments[0]);

                    Assert.IsNotNull(originalProperties.Jpeg2000Properties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                    Assert.IsNotNull(originalProperties.Jpeg2000Properties.Comments);
                    Assert.AreNotEqual(comment, originalProperties.Jpeg2000Properties.Comments[0]);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test CreateModifiedJpeg2000
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void CreateModifiedJpeg2000Test(bool saveResultToStorage)
        {
            string name = "test.j2k";
            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string outName = $"{name}_specific.jp2";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "CreateModifiedJpeg2000Test",
                saveResultToStorage,
                $"Input image: {name}; Comment: {comment}; Codec: {codec}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new CreateModifiedJpeg2000Request(inputStream, comment, codec, fromScratch, outPath, storage);
                    return ImagingApi.CreateModifiedJpeg2000(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.Jpeg2000Properties);

                    Assert.IsNotNull(resultProperties.Jpeg2000Properties.Codec);
                    Assert.AreEqual(codec, resultProperties.Jpeg2000Properties.Codec.ToString().ToLower());
                    Assert.IsNotNull(resultProperties.Jpeg2000Properties.Comments);
                    Assert.AreEqual(comment, resultProperties.Jpeg2000Properties.Comments[0]);

                    Assert.IsNotNull(originalProperties.Jpeg2000Properties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                    Assert.IsNotNull(originalProperties.Jpeg2000Properties.Comments);
                    Assert.AreNotEqual(comment, originalProperties.Jpeg2000Properties.Comments[0]);
                },
                folder,
                storage);
        }
    }
}
