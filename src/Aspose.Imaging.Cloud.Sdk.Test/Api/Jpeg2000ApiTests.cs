// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Jpeg2000ApiTests.cs">
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
    ///  Class for testing Jpeg2000Api
    /// </summary>
    [TestFixture]
    public class Jpeg2000ApiTests : ApiTester
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
        /// Test GetImageJpeg2000
        /// TODO: improve test when IMAGINGNET-2872 is done 
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageJpeg2000Test(bool saveResultToStorage)
        {
            string name = "test.j2k";
            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string outName = $"{name}_specific.jp2";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageJpeg2000Test",
                saveResultToStorage,
                $"Input image: {name}; Comment: {comment}; Codec: {codec}",
                name,
                outName,
                "Jpeg2000",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageJpeg2000Request(name, comment, codec, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageJpeg2000(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.Jpeg2000Properties);
                    Assert.IsTrue(resultProperties.Jpeg2000Properties.Codec.HasValue);

                    // TODO: uncomment when IMAGINGNET-2872 is done 
                    //Assert.AreEqual(outProperties.Jpeg2000Properties.Codec.ToString().ToLower(), codec);
                    Assert.NotNull(resultProperties.Jpeg2000Properties.Comments);
                    Assert.IsTrue(resultProperties.Jpeg2000Properties.Comments.Contains(comment));

                    Assert.NotNull(originalProperties.Jpeg2000Properties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                    Assert.NotNull(originalProperties.Jpeg2000Properties.Comments);
                    Assert.IsFalse(originalProperties.Jpeg2000Properties.Comments.Contains(comment));
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageJpeg2000
        /// TODO: improve test when IMAGINGNET-2872 is done 
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageJpeg2000Test(bool saveResultToStorage)
        {
            string name = "test.j2k";
            string codec = "jp2";
            string comment = "Aspose";
            bool? fromScratch = null;
            string outName = $"{name}_specific.jp2";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageJpeg2000Test",
                saveResultToStorage,
                $"Input image: {name}; Comment: {comment}; Codec: {codec}",
                name,
                outName,
                "Jpeg2000",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageJpeg2000Request(inputStream, comment, codec, fromScratch, outPath);
                    return ImagingApi.PostImageJpeg2000(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.NotNull(resultProperties.Jpeg2000Properties);
                    Assert.IsTrue(resultProperties.Jpeg2000Properties.Codec.HasValue);

                    // TODO: uncomment when IMAGINGNET-2872 is done 
                    //Assert.AreEqual(outProperties.Jpeg2000Properties.Codec.ToString().ToLower(), codec);
                    Assert.NotNull(resultProperties.Jpeg2000Properties.Comments);
                    Assert.IsTrue(resultProperties.Jpeg2000Properties.Comments.Contains(comment));

                    Assert.NotNull(originalProperties.Jpeg2000Properties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                    Assert.NotNull(originalProperties.Jpeg2000Properties.Comments);
                    Assert.IsFalse(originalProperties.Jpeg2000Properties.Comments.Contains(comment));
                },
                folder,
                storage);
        }
    }
}
