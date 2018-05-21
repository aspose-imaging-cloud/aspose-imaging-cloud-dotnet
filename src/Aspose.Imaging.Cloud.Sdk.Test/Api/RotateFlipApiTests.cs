// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RotateFlipApiTests.cs">
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
    using System;
    using System.IO;
    using System.Collections.Generic;
    using NUnit.Framework;

    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    using Aspose.Storage.Cloud.Sdk.Model;

    /// <summary>
    ///  Class for testing RotateFlipApi
    /// </summary>
    [TestFixture]
    public class RotateFlipApiTests : ApiTester
    {
        /// <summary>
        /// Test GetImageRotateFlip
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".jpg", true)]
        [TestCase(".jpg", false)]
        public void GetImageRotateFlipTest(string formatExtension, bool saveResultToStorage,
            params string[] additionalExportFormats)
        {
            string name = null;
            string method = "Rotate90FlipX";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (FileResponse inputFile in InputTestFiles)
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

                    this.TestGetRequest(
                        "GetImageRotateFlipTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format}; Method: {method}",
                        name,
                        outName,
                        "RotateFlip",
                        delegate(string fileName, string outPath)
                        {
                            var request =
                                new GetImageRotateFlipRequest(fileName, format, method, outPath, folder, storage);
                            return ImagingApi.GetImageRotateFlip(request);
                        },
                        delegate(ImagingResponse originalProperties, ImagingResponse resultProperties)
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
        public void PostImageRotateFlipTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            string method = "Rotate90FlipX";
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (FileResponse inputFile in InputTestFiles)
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
                        "RotateFlip",
                        delegate (Stream inputStream, string outPath)
                        {
                            var request =
                                new PostImageRotateFlipRequest(inputStream, format, method, outPath, storage);
                            return ImagingApi.PostImageRotateFlip(request);
                        },
                        delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
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
