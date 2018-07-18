// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsApiTests.cs">
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
	using System.Collections.Generic;
	using NUnit.Framework;

	using Aspose.Storage.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing SaveAsApi
    /// </summary>
    [Category("SaveAs")]
    [TestFixture]
    public class SaveAsApiTests : ImagingApiTester
    {
        /// <summary>
        /// Performs SaveAs (export to another format) operation test with GET method, taking input data from storage.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If resulting image should be saved to storage</param>
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
        public void GetImageSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            string folder = CloudTestFolder;
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
                    outName = $"{name}.{format}";

                    this.TestGetRequest(
                        "GetImageSaveAsTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format}",
                        name,
                        outName,
                        "Common",
                        delegate (string fileName, string outPath)
                        {
                            var request =
                                new GetImageSaveAsRequest(fileName, format, outPath, folder, storage);
                            return ImagingApi.GetImageSaveAs(request);
                        },
                        null,
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Performs SaveAs (export to another format) operation test with POST method, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If resulting image should be saved to storage</param>
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
        public void PostImageSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            string folder = CloudTestFolder;
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
                    outName = $"{name}.{format}";

                    this.TestPostRequest(
                        "PostImageSaveAsTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format}",
                        name,
                        outName,
                        "Common",
                        delegate (Stream inputStream, string outPath)
                        {
                            var request =
                                new PostImageSaveAsRequest(inputStream, format, outPath, storage);
                            return ImagingApi.PostImageSaveAs(request);
                        },
                        null,
                        folder,
                        storage);
                }
            }
        }
    }
}
