// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsApiTests.cs">
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
	using System.Collections.Generic;
	using NUnit.Framework;

	using Aspose.Imaging.Cloud.Sdk.Model.Requests;
	using Aspose.Imaging.Cloud.Sdk.Test.Base;

    /// <summary>
    ///  Class for testing SaveAsApi
    /// </summary>
    [TestFixture]
    public class SaveAsApiTests : ApiTester
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
        /// Performs SaveAs (export to another format) operation test with GET method, taking input data from storage.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If resulting image should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".bmp", false)]
        [TestCase(".bmp", true)]
        [TestCase(".dicom", true)]
        [TestCase(".dicom", false)]
        [TestCase(".dng", true)]
        [TestCase(".dng", false)]
        [TestCase(".gif", true)]
        [TestCase(".gif", false)]
        [TestCase(".png", true)]
        [TestCase(".png", false)]
        [TestCase(".jpg", true)]
        [TestCase(".jpg", false)]
        [TestCase(".jpeg", true)]
        [TestCase(".jpeg", false)]
        [TestCase(".tif", true)]
        [TestCase(".tif", false)]
        [TestCase(".tiff", true)]
        [TestCase(".tiff", false)]
        [TestCase(".webp", true)]
        [TestCase(".webp", false)]
        [TestCase(".psd", true)]
        [TestCase(".psd", false)]
        [TestCase(".j2k", true)]
        [TestCase(".j2k", false)]
        [TestCase(".jpf", true)]
        [TestCase(".jpf", false)]
        [TestCase(".jpx", true)]
        [TestCase(".jpx", false)]
        [TestCase(".jpm", true)]
        [TestCase(".jpm", false)]
        [TestCase(".mj2", true)]
        [TestCase(".mj2", false)]
        [TestCase(".jpg2", true)]
        [TestCase(".jpg2", false)]
        [TestCase(".mjp2", true)]
        [TestCase(".mjp2", false)]
        [TestCase(".odg", true)]
        [TestCase(".odg", false)]
        [TestCase(".emf", true)]
        [TestCase(".emf", false)]
        [TestCase(".wmf", true)]
        [TestCase(".wmf", false)]
        public void GetImageSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
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

            foreach (FilesList.StorageFileInfo inputFile in InputTestFiles)
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
        [TestCase(".bmp", false)]
        [TestCase(".bmp", true)]
        [TestCase(".dicom", true)]
        [TestCase(".dicom", false)]
        [TestCase(".dng", true)]
        [TestCase(".dng", false)]
        [TestCase(".gif", true)]
        [TestCase(".gif", false)]
        [TestCase(".png", true)]
        [TestCase(".png", false)]
        [TestCase(".jpg", true)]
        [TestCase(".jpg", false)]
        [TestCase(".jpeg", true)]
        [TestCase(".jpeg", false)]
        [TestCase(".tif", true)]
        [TestCase(".tif", false)]
        [TestCase(".tiff", true)]
        [TestCase(".tiff", false)]
        [TestCase(".webp", true)]
        [TestCase(".webp", false)]
        [TestCase(".psd", true)]
        [TestCase(".psd", false)]
        [TestCase(".j2k", true)]
        [TestCase(".j2k", false)]
        [TestCase(".jpf", true)]
        [TestCase(".jpf", false)]
        [TestCase(".jpx", true)]
        [TestCase(".jpx", false)]
        [TestCase(".jpm", true)]
        [TestCase(".jpm", false)]
        [TestCase(".mj2", true)]
        [TestCase(".mj2", false)]
        [TestCase(".jpg2", true)]
        [TestCase(".jpg2", false)]
        [TestCase(".mjp2", true)]
        [TestCase(".mjp2", false)]
        [TestCase(".odg", true)]
        [TestCase(".odg", false)]
        [TestCase(".emf", true)]
        [TestCase(".emf", false)]
        [TestCase(".wmf", true)]
        [TestCase(".wmf", false)]
        public void PostImageSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
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

            foreach (FilesList.StorageFileInfo inputFile in InputTestFiles)
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
