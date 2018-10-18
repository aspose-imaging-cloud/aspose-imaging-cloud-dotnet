// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OdgApiTests.cs">
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
    using System;
    using System.IO;
	using NUnit.Framework;

	using Aspose.Imaging.Cloud.Sdk.Model;
	using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing OdgApi
    /// </summary>
    [Category("v1.0")]
    [Category("v2.0")]
    [Category("Odg")]
    [TestFixture]
    public class OdgApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test GetImageOdg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImageOdgTest(bool saveResultToStorage)
        {
            string name = "test.odg";
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "GetImageOdgTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                delegate (string fileName, string outPath)
                {
                    var request = new GetImageOdgRequest(fileName, fromScratch, outPath, folder, storage);
                    return ImagingApi.GetImageOdg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.PngProperties);
                    try
                    {
                        Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    }
                    catch (Exception)
                    {
                        Assert.AreEqual(originalProperties.Width, resultProperties.Width - 1);
                    }

                    try
                    {
                        Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                    }
                    catch (Exception)
                    {
                        Assert.AreEqual(originalProperties.Height, resultProperties.Height - 1);
                    }

                    Assert.IsNotNull(originalProperties.OdgProperties);
                    Assert.IsNotNull(originalProperties.OdgProperties.Pages);
                    Assert.AreEqual(originalProperties.OdgProperties.PageCount, 2);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Width,
                        originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Height,
                        originalProperties.Height);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Width,
                        originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Height,
                        originalProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostImageOdg
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageOdgTest(bool saveResultToStorage)
        {
            string name = "test.odg";
            bool? fromScratch = null;
            string outName = $"{name}_specific.png";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "PostImageOdgTest",
                saveResultToStorage,
                $"Input image: {name}",
                name,
                outName,
                delegate (Stream inpuStream, string outPath)
                {
                    var request = new PostImageOdgRequest(inpuStream, fromScratch, outPath, storage);
                    return ImagingApi.PostImageOdg(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.IsNotNull(resultProperties.PngProperties);
                    try
                    {
                        Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    }
                    catch (Exception)
                    {
                        Assert.AreEqual(originalProperties.Width, resultProperties.Width - 1);
                    }

                    try
                    {
                        Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                    }
                    catch (Exception)
                    {
                        Assert.AreEqual(originalProperties.Height, resultProperties.Height - 1);
                    }

                    Assert.IsNotNull(originalProperties.OdgProperties);
                    Assert.IsNotNull(originalProperties.OdgProperties.Pages);
                    Assert.AreEqual(originalProperties.OdgProperties.PageCount, 2);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Width,
                        originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[0].Height,
                        originalProperties.Height);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Width,
                        originalProperties.Width);
                    Assert.AreEqual(originalProperties.OdgProperties.Pages[1].Height,
                        originalProperties.Height);
                },
                folder,
                storage);
        }
    }
}
