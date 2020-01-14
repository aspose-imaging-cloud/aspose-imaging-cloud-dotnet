// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeskewApiTests.cs">
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
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class DeskewApiTests : ImagingApiTester
    {
        /// <summary>
        /// Deskew image test
        /// </summary>
        /// <param name="formatExtension">image format to test</param>
        /// <param name="resizeProportionally">Resize proportionally</param>
        /// <param name="bkColor">Background color</param>
        [TestCase("jpg", true)]
        [TestCase("jpg", false)]
        [TestCase("jpg", false, "green")]
#if EXTENDED_TEST
        [TestCase("bmp", true)]
        //todo: enable after save of images of these fomats is implemented
        //[TestCase("dicom", true)]
        //[TestCase("djvu", true)]
        //[TestCase("dng", true)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        //[TestCase("gif", true)]
        [TestCase("j2k", true)]
        [TestCase("jp2", true)]
        [TestCase("jpx", true)]
        [TestCase("jpm", true)]
        [TestCase("jpeg", true)]
        [TestCase("png", true)]
        [TestCase("psd", true)]
        [TestCase("tiff", true)]
        [TestCase("tif", true)]
        [TestCase("webp", true)]
#endif
        public void DeskewImageTest(string formatExtension, bool resizeProportionally, string bkColor = null)
        {
            foreach (StorageFile inputFile in InputTestFiles.Where(f => f.Name.EndsWith("." + formatExtension)))
            {
                this.TestGetRequest(
                    "DeskewImageTest",
                    $"Input image: {inputFile.Name}; Output format: {formatExtension}; Resize proportionally: {resizeProportionally}; Background color: {bkColor ?? "null"};",
                    inputFile.Name,
                    delegate
                    {
                        var request = new DeskewImageRequest(inputFile.Name, resizeProportionally, bkColor, TempFolder,
                            TestStorage);
                        return ImagingApi.DeskewImage(request);
                    },
                    delegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                    {
                        Assert.NotNull(resultStream);
                        resultStream.Position = 0;
                        Assert.IsTrue(ImageFormatsEqual(Image.Load(resultStream).FileFormat, formatExtension));
                    },
                    TempFolder,
                    TestStorage);
            }
        }

        /// <summary>
        /// Create deskew image test
        /// </summary>
        /// <param name="formatExtension">Format extension</param>
        /// <param name="saveResultToStorage">Save results to storage</param>
        /// <param name="resizeProportionally">Resize proportionally</param>
        /// <param name="bkColor">Background color</param>
        [TestCase("jpg", true, true)]
        [TestCase("jpg", false, false)]
        [TestCase("jpg", false, true, "green")]
#if EXTENDED_TEST
        [TestCase("bmp", true, true)]
        //todo: enable after save of images of these fomats is implemented
        //[TestCase("dicom",  true, true)]
        //[TestCase("djvu", true, true)]
        //[TestCase("dng", true, true)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        //[TestCase("gif", true, true)]
        [TestCase("j2k", true, true)]
        [TestCase("jp2", true, true)]
        [TestCase("jpx", true, true)]
        [TestCase("jpm", true, true)]
        [TestCase("jpeg", true, true)]
        [TestCase("png", true, true)]
        [TestCase("psd", true, true)]
        [TestCase("tiff", true, true)]
        [TestCase("tif", true, true)]
        [TestCase("webp", true, true)]
#endif
        public void CreateDeskewedImageTest(
            string formatExtension,
            bool saveResultToStorage,
            bool resizeProportionally,
            string bkColor = null)
        {
            foreach (StorageFile inputFile in InputTestFiles.Where(f => f.Name.EndsWith(formatExtension)))
            {
                string outName = $"{inputFile.Name}_deskew.{formatExtension}";

                this.TestPostRequest(
                    "DeskewImageTest",
                    saveResultToStorage,
                    $"Input image: {inputFile.Name}; Output format: {formatExtension}; Resize proportionally: {resizeProportionally}; Background color: {bkColor ?? "null"};",
                    inputFile.Name,
                    outName,
                    delegate(Stream inputStream, string outPath)
                    {
                        var request = new CreateDeskewedImageRequest(inputStream, resizeProportionally, bkColor, outPath, TestStorage);
                        return ImagingApi.CreateDeskewedImage(request);
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

        /// <summary>
        /// Checks if image formats equal
        /// </summary>
        /// <param name="asposeImageFormat"></param>
        /// <param name="formatExtension"></param>
        /// <returns>Boolean</returns>
        private bool ImageFormatsEqual(FileFormat asposeImageFormat, string formatExtension)
        {
            formatExtension = formatExtension.ToLower();

            if (String.Equals(asposeImageFormat.ToString(), formatExtension, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }

            if (asposeImageFormat == FileFormat.Jpeg && formatExtension == "jpg")
            {
                return true;
            }

            return false;
        }
    }
}