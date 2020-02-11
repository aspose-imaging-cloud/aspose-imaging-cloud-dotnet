// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GrayscaleApiTests.cs">
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
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class GrayscaleApiTests : ImagingApiTester
    {
        /// <summary>
        /// Grayscale image test
        /// </summary>
        /// <param name="formatExtension">image format to test</param>
        [TestCase("jpg")]
        public void GrayscaleImageTest(string formatExtension)
        {
            foreach (StorageFile inputFile in InputTestFiles.Where(f => f.Name.EndsWith("." + formatExtension)))
            {
                this.TestGetRequest(
                    "GrayscaleImageTest",
                    $"Input image: {inputFile.Name}; Output format: {formatExtension};",
                    inputFile.Name,
                    delegate
                    {
                        var request = new GrayscaleImageRequest(inputFile.Name, TempFolder, TestStorage);
                        return ImagingApi.GrayscaleImage(request);
                    },
                    delegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                    {
                        Assert.NotNull(resultStream);
                        Assert.IsTrue(resultStream.Length > 0);
                    },
                    TempFolder,
                    TestStorage);
            }
        }

        /// <summary>
        /// Create grayscale image test
        /// </summary>
        /// <param name="formatExtension">Format extension</param>
        /// <param name="saveResultToStorage">Save results to storage</param>
        [TestCase("jpg", true)]
        [TestCase("jpg", false)]
        public void CreateGrayscaleedImageTest(string formatExtension, bool saveResultToStorage)
        {
            foreach (StorageFile inputFile in InputTestFiles.Where(f => f.Name.EndsWith(formatExtension)))
            {
                string outName = $"{inputFile.Name}_grayscale.{formatExtension}";

                this.TestPostRequest(
                    "GrayscaleImageTest",
                    saveResultToStorage,
                    $"Input image: {inputFile.Name}; Output format: {formatExtension};",
                    inputFile.Name,
                    outName,
                    delegate(Stream inputStream, string outPath)
                    {
                        var request = new CreateGrayscaledImageRequest(inputStream, outPath, TestStorage);
                        return ImagingApi.CreateGrayscaledImage(request);
                    },
                    delegate(ImagingResponse originalProperties, ImagingResponse resultProperties,
                        Stream resultStream)
                    {
                        if (!saveResultToStorage)
                        {
                            Assert.NotNull(resultStream);
                            Assert.IsTrue(resultStream.Length > 0);
                        }
                        else
                        {
                            Assert.IsTrue(originalProperties.BitsPerPixel == resultProperties.BitsPerPixel);
                        }
                    },
                    TempFolder,
                    TestStorage);
            }
        }
    }
}