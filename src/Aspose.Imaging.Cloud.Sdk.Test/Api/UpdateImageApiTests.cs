// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WebPApiTests.cs">
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
	using Aspose.Imaging.Cloud.Sdk.Model;
	using Aspose.Imaging.Cloud.Sdk.Model.Requests;
	using Aspose.Imaging.Cloud.Sdk.Test.Base;
	
    /// <summary>
    ///  Class for testing UpdateImageApi
    /// </summary>
    [TestFixture]
    public class UpdateImageApiTests : ApiTester
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
        /// Test GetImageUpdate
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".bmp", true)]
        [TestCase(".dng", true)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        // [TestCase(".gif", true)]
        [TestCase(".png", true)]
        [TestCase(".jpg", true)]
        [TestCase(".jpeg", true)]
        [TestCase(".tif", true)]
        [TestCase(".tiff", true)]
        [TestCase(".webp", true)]
        [TestCase(".psd", true)]
        [TestCase(".j2k", true)]
        [TestCase(".jpf", true)]
        [TestCase(".jpx", true)]
        [TestCase(".jpm", true)]
        [TestCase(".mj2", true)]
        [TestCase(".jpg2", true)]
        [TestCase(".mjp2", true)]
        [TestCase(".bmp", false)]
        [TestCase(".dng", false)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        // [TestCase(".gif", false)]
        [TestCase(".png", false)]
        [TestCase(".jpg", false)]
        [TestCase(".jpeg", false)]
        [TestCase(".tif", false)]
        [TestCase(".tiff", false)]
        [TestCase(".webp", false)]
        [TestCase(".psd", false)]
        [TestCase(".j2k", false)]
        [TestCase(".jpf", false)]
        [TestCase(".jpx", false)]
        [TestCase(".jpm", false)]
        [TestCase(".mj2", false)]
        [TestCase(".jpg2", false)]
        [TestCase(".mjp2", false)]
        public void GetImageUpdateTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
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
                    outName = $"{name}_update.{format}";

                    this.TestGetRequest(
                        "GetImageUpdateTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format}; New width: {newWidth}; New height: {newHeight}; Rotate/flip method: {rotateFlipMethod}; " +
                        $"X: {x}; Y: {y}; Rect width: {rectWidth}; Rect height: {rectHeight}",
                        name,
                        outName,
                        "Update",
                        delegate (string fileName, string outPath)
                        {
                            var request = new GetImageUpdateRequest(fileName, format, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, outPath, folder, storage);
                            return ImagingApi.GetImageUpdate(request);
                        },
                        delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                        {
                            Assert.AreEqual(resultProperties.Width, rectHeight);
                            Assert.AreEqual(resultProperties.Height, rectWidth);
                        },
                        folder,
                        storage);
                }
            }          
        }

        /// <summary>
        /// Test PostImageUpdate
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".bmp", true)]
        [TestCase(".dng", true)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        // [TestCase(".gif", true)]
        [TestCase(".png", true)]
        [TestCase(".jpg", true)]
        [TestCase(".jpeg", true)]
        [TestCase(".tif", true)]
        [TestCase(".tiff", true)]
        [TestCase(".webp", true)]
        [TestCase(".psd", true)]
        [TestCase(".j2k", true)]
        [TestCase(".jpf", true)]
        [TestCase(".jpx", true)]
        [TestCase(".jpm", true)]
        [TestCase(".mj2", true)]
        [TestCase(".jpg2", true)]
        [TestCase(".mjp2", true)]
        [TestCase(".bmp", false)]
        [TestCase(".dng", false)]
        // TODO: enable after IMAGINGCLOUD-51 is resolved
        // [TestCase(".gif", false)]
        [TestCase(".png", false)]
        [TestCase(".jpg", false)]
        [TestCase(".jpeg", false)]
        [TestCase(".tif", false)]
        [TestCase(".tiff", false)]
        [TestCase(".webp", false)]
        [TestCase(".psd", false)]
        [TestCase(".j2k", false)]
        [TestCase(".jpf", false)]
        [TestCase(".jpx", false)]
        [TestCase(".jpm", false)]
        [TestCase(".mj2", false)]
        [TestCase(".jpg2", false)]
        [TestCase(".mjp2", false)]
        public void PostImageUpdateTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            int? newWidth = 300;
            int? newHeight = 450;
            int? x = 10;
            int? y = 10;
            int? rectWidth = 200;
            int? rectHeight = 300;
            string rotateFlipMethod = "Rotate90FlipX";
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
                    outName = $"{name}_update.{format}";

                    this.TestPostRequest(
                        "PostImageUpdateTest",
                        saveResultToStorage,
                        $"Input image: {name}; Output format: {format}; New width: {newWidth}; New height: {newHeight}; Rotate/flip method: {rotateFlipMethod}; " +
                        $"X: {x}; Y: {y}; Rect width: {rectWidth}; Rect height: {rectHeight}",
                        name,
                        outName,
                        "Update",
                        delegate (Stream inputStream, string outPath)
                        {
                            var request = new PostImageUpdateRequest(inputStream, format, newWidth, newHeight, x, y, rectWidth, rectHeight, rotateFlipMethod, outPath, storage);
                            return ImagingApi.PostImageUpdate(request);
                        },
                        delegate (ImagingResponse originalProperties, ImagingResponse resultProperties)
                        {
                            Assert.AreEqual(resultProperties.Width, rectHeight);
                            Assert.AreEqual(resultProperties.Height, rectWidth);
                        },
                        folder,
                        storage);
                }
            }
        }
    }
}
