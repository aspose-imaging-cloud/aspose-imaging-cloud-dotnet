// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RotateFlipApiTests.cs">
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
    using System;
    using System.IO;
    using System.Collections.Generic;
    using NUnit.Framework;

    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing RotateFlipApi
    /// </summary>
    [Category("v3.0")]
    [Category("RotateFlip")]
    [TestFixture]
    public class RotateFlipApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test GetImageRotateFlip
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".jpg")]
#if EXTENDED_TEST
        [TestCase(".bmp")]
        [TestCase(".dicom")]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        //[TestCase(".gif")]
        [TestCase(".j2k")]
        [TestCase(".png")]
        [TestCase(".psd")]
        [TestCase(".tiff")]
        [TestCase(".webp")]
#endif
        public void GetImageRotateFlipTest(string formatExtension, params string[] additionalExportFormats)
        {
            string name = null;
            string method = "Rotate90FlipX";
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
                        "GetImageRotateFlipTest",
                        $"Input image: {name}; Output format: {format}; Method: {method}",
                        name,
                        delegate
                        {
                            var request =
                                new GetImageRotateFlipRequest(name, format, method, folder, storage);
                            return ImagingApi.GetImageRotateFlip(request);
                        },
                        delegate(ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                        {
                            try
                            {
                                Assert.AreEqual(originalProperties.Height, resultProperties.Width);
                            }
                            catch (Exception)
                            {
                                Assert.AreEqual(originalProperties.Height - 1, resultProperties.Width);
                            }

                            try
                            {
                                Assert.AreEqual(originalProperties.Width, resultProperties.Height);
                            }
                            catch (Exception)
                            {
                                Assert.AreEqual(originalProperties.Width - 1, resultProperties.Height);
                            }
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Test PostImageRotateFlip
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".jpg", true)]
        [TestCase(".jpg", false)]
#if EXTENDED_TEST
        [TestCase(".bmp", true)]
        [TestCase(".bmp", false)]
        [TestCase(".dicom", true)]
        [TestCase(".dicom", false)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        //[TestCase(".gif", true)]
        //[TestCase(".gif", false)]
        [TestCase(".j2k", true)]
        [TestCase(".j2k", false)]
        [TestCase(".png", true)]
        [TestCase(".png", false)]
        [TestCase(".psd", true)]
        [TestCase(".psd", false)]
        [TestCase(".tiff", true)]
        [TestCase(".tiff", false)]
        [TestCase(".webp", true)]
        [TestCase(".webp", false)]
#endif
        public void PostImageRotateFlipTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            string method = "Rotate90FlipX";
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
                    outName = $"{name}_rotateFlip.{format}";

                    this.TestPostRequest(
                        "PostImageRotateFlipTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format}; Method: {method}",
                        name,
                        outName,
                        delegate (Stream inputStream, string outPath)
                        {
                            var request =
                                new PostImageRotateFlipRequest(inputStream, format, method, outPath, storage);
                            return ImagingApi.PostImageRotateFlip(request);
                        },
                        delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                        {
                            try
                            {
                                Assert.AreEqual(originalProperties.Height, resultProperties.Width);
                            }
                            catch (Exception)
                            {
                                Assert.AreEqual(originalProperties.Height - 1, resultProperties.Width);
                            }

                            try
                            {
                                Assert.AreEqual(originalProperties.Width, resultProperties.Height);
                            }
                            catch (Exception)
                            {
                                Assert.AreEqual(originalProperties.Width - 1, resultProperties.Height);
                            }
                        },
                        folder,
                        storage);
                }
            }
        }
    }
}
