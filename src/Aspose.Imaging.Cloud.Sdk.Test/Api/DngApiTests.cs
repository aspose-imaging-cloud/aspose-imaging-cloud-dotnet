// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DngApiTests.cs">
//   Copyright (c) 2018 Aspose Pty Ltd.
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
    ///  Class for testing DngApi
    /// </summary>
    [TestFixture]
    public class DngApiTests : ApiTester
    {
        /// <summary>
        /// Test GetImageDng
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageDngTest(bool saveResultToStorage)
        {
            string name = "test.dng";
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestGetRequest(
                "GetImageDngTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                "Dng",
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageDngRequest(fileName, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageDng(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.IsNotNull(resultProperties.PngProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);

                    Assert.IsNotNull(originalProperties.DngProperties);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageDng
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageDngTest(bool saveResultToStorage)
        {
            string name = "test.dng";
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestPostRequest(
                "PostImageDngTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                "Dng",
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageDngRequest(inputStream, fromScratch, outPath, storage);
                    return ImagingApi.PostImageDng(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                {
                    Assert.IsNotNull(resultProperties.PngProperties);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);

                    Assert.IsNotNull(originalProperties.DngProperties);
                },
                folder,
                storage);
        }
    }
}
