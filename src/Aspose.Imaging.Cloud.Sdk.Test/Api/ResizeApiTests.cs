// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ResizeApiTests.cs">
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
    using System.Collections.Generic;
    using NUnit.Framework;

    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing ResizeApi
    /// </summary>
    [Category("v3.0")]
    [Category("Resize")]
    [TestFixture]
    public class ResizeApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test ResizeImage
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".jpg", null)]
#if EXTENDED_TEST
        [TestCase(".bmp", null)]
        [TestCase(".dicom", null)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        //[TestCase(".gif", null)]
        [TestCase(".j2k", null)]
        [TestCase(".png", null)]
        [TestCase(".psd", null)]
        [TestCase(".tiff", null)]
        [TestCase(".webp", null)]
#endif
        public void ResizeImageTest(string formatExtension, params string[] additionalExportFormats)
        {
            string name = null;
            int? newWidth = 100;
            int? newHeight = 150;
            string folder = TempFolder;
            string storage = this.TestStorage;

            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (StorageFile inputFile in InputTestFiles)
            {
                if (inputFile.Name.EndsWith(formatExtension))
                {
                    name = inputFile.Name;
                }
                else
                {
                    continue;
                }

                foreach (string format in formatsToExport)
                {
                    this.TestGetRequest(
                        "ResizeImageTest",
                        $"Input image: {name}; Output format: {format ?? "null"}; New width: {newWidth}; New height: {newHeight}",
                        name,
                        delegate
                        {
                            var request = new ResizeImageRequest(name, newWidth, newHeight, format, folder, storage);
                            return ImagingApi.ResizeImage(request);
                        },
                        delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                        {
                            if (format is null)
                            {
                                AssertImageFormatsEqual(resultStream, formatExtension);
                            }
                            
                            Assert.AreEqual(newWidth, resultProperties.Width);
                            Assert.AreEqual(newHeight, resultProperties.Height);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Test CreateResizedImage
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".jpg", true, null)]
        [TestCase(".jpg", false, null)]
#if EXTENDED_TEST
        [TestCase(".bmp", true, null)]
        [TestCase(".bmp", false, null)]
        [TestCase(".dicom", true, null)]
        [TestCase(".dicom", false, null)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        //[TestCase(".gif", true, null)]
        //[TestCase(".gif", false, null)]
        [TestCase(".j2k", true, null)]
        [TestCase(".j2k", false, null)]
        [TestCase(".png", true, null)]
        [TestCase(".png", false, null)]
        [TestCase(".psd", true, null)]
        [TestCase(".psd", false, null)]
        [TestCase(".tiff", true, null)]
        [TestCase(".tiff", false, null)]
        [TestCase(".webp", true, null)]
        [TestCase(".webp", false, null)]
#endif
        public void CreateResizedImageTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            int? newWidth = 100;
            int? newHeight = 150;
            string folder = TempFolder;
            string storage = this.TestStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (StorageFile inputFile in InputTestFiles)
            {
                if (inputFile.Name.EndsWith(formatExtension))
                {
                    name = inputFile.Name;
                }
                else
                {
                    continue;
                }

                foreach (string format in formatsToExport)
                {
                    outName = $"{name}_resize.{format ?? formatExtension.Substring(1)}";

                    this.TestPostRequest(
                        "CreateResizedImageTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format ?? "null"}; New width: {newWidth}; New height: {newHeight}",
                        name,
                        outName,
                        delegate (Stream inputStream, string outPath)
                        {
                            var request = new CreateResizedImageRequest(inputStream, newWidth, newHeight, format, outPath, storage);
                            return ImagingApi.CreateResizedImage(request);
                        },
                        delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                        {
                            if (!saveResultToStorage && format is null)
                            {
                                AssertImageFormatsEqual(resultStream, formatExtension);
                            }
                            
                            Assert.AreEqual(newWidth, resultProperties.Width);
                            Assert.AreEqual(newHeight, resultProperties.Height);
                        },
                        folder,
                        storage);
                }
            }
        }
    }
}
