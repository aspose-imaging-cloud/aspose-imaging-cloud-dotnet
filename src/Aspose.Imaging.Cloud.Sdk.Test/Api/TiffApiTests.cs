// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffApiTests.cs">
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
    using NUnit.Framework;
    
    using Aspose.Imaging.Cloud.Sdk.Model;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;

    /// <summary>
    ///  Class for testing TiffApi
    /// </summary>
    [TestFixture]
    [Category("v3.0")]
    [Category("Tiff")]
    public class TiffApiTests : ImagingApiTester
    {
        /// <summary>
        /// Test GetTiffToFax
        /// </summary>
        [Test]
        public void GetTiffToFaxTest()
        {
            string name = "test.tiff";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "GetTiffToFaxTest",
                $"Input image: {name}",
                name,
                delegate
                {
                    var request = new GetTiffToFaxRequest(name, storage, folder);
                    return ImagingApi.GetTiffToFax(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(resultProperties.TiffProperties);
                    Assert.AreEqual(1, resultProperties.BitsPerPixel);
                    Assert.AreEqual(196, (int)Math.Ceiling((double)resultProperties.VerticalResolution));
                    Assert.AreEqual(204, (int)Math.Ceiling((double)resultProperties.HorizontalResolution));
                    Assert.AreEqual(1728, resultProperties.Width);
                    Assert.AreEqual(2200, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test GetImageTiff
        /// </summary>
        [Test]
        public void GetImageTiffTest()
        {
            string name = "test.tiff";
            string compression = "adobedeflate";
            string resolutionUnit = "inch";
            int bitDepth = 1;
            double horizontalResolution = 150;
            double verticalResolution = 150;
            bool? fromScratch = null;
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                "GetImageTiffTest",
                $"Input image: {name}; Compression: {compression}; Bit depth: {bitDepth}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                delegate
                {
                    var request = new GetImageTiffRequest(name, bitDepth, compression, resolutionUnit, horizontalResolution, 
                        verticalResolution, fromScratch, folder, storage);
                    return ImagingApi.GetImageTiff(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(resultProperties.TiffProperties);
                    Assert.AreEqual(bitDepth > 1 ? bitDepth * 4 : bitDepth, resultProperties.BitsPerPixel);
                    Assert.AreEqual((int)verticalResolution, (int)Math.Ceiling((double)resultProperties.VerticalResolution));
                    Assert.AreEqual((int)horizontalResolution, (int)Math.Ceiling((double)resultProperties.HorizontalResolution));

                    Assert.NotNull(originalProperties.TiffProperties);
                    Assert.AreEqual(originalProperties.TiffProperties.Frames.Count, resultProperties.TiffProperties.Frames.Count);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostProcessTiff
        /// </summary>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        [TestCase(true)]
        [TestCase(false)]
        public void PostImageTiffTest(bool saveResultToStorage)
        {
            string name = "test.tiff";
            string compression = "adobedeflate";
            string resolutionUnit = "inch";
            int bitDepth = 1;
            double horizontalResolution = 150;
            double verticalResolution = 150;
            bool? fromScratch = null;
            string outName = $"{name}_specific.tiff";
            string folder = TempFolder;
            string storage = this.TestStorage;

            this.TestPostRequest(
                "PostImageTiffTest",
                saveResultToStorage,
                $"Input image: {name}; Compression: {compression}; Bit depth: {bitDepth}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                outName,
                delegate (Stream inputStream, string outPath)
                {
                    var request = new PostImageTiffRequest(inputStream, bitDepth, compression, resolutionUnit,
                        horizontalResolution, verticalResolution, fromScratch, outPath, storage);
                    return ImagingApi.PostImageTiff(request);
                },
                delegate (ImagingResponse originalProperties, ImagingResponse resultProperties, Stream resultStream)
                {
                    Assert.NotNull(resultProperties.TiffProperties);
                    Assert.AreEqual(bitDepth > 1 ? bitDepth * 4 : bitDepth, resultProperties.BitsPerPixel);
                    Assert.AreEqual((int)verticalResolution, (int)Math.Ceiling((double)resultProperties.VerticalResolution));
                    Assert.AreEqual((int)horizontalResolution, (int)Math.Ceiling((double)resultProperties.HorizontalResolution));

                    Assert.NotNull(originalProperties.TiffProperties);
                    Assert.AreEqual(originalProperties.TiffProperties.Frames.Count, resultProperties.TiffProperties.Frames.Count);
                    Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                    Assert.AreEqual(originalProperties.Height, resultProperties.Height);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Test PostTiffAppend
        /// </summary>
        [Test]
        public void PostTiffAppendTest()
        {
            bool passed = false;
            WriteLineEverywhere("PostTiffAppendTest");

            string inputFileName = "test.tiff";
            string folder = TempFolder;

            if (!CheckInputFileExists(inputFileName))
            {
                throw new ArgumentException(
                    $"Input file {inputFileName} doesn't exist in the specified storage folder: {folder}. Please, upload it first.");
            }

            string resultFileName = $"{inputFileName}_merged.tiff";
            string outPath = null;
            string inputPath = TempFolder + "/" + inputFileName;
            string storage = this.TestStorage;

            try
            {
                WriteLineEverywhere($"Input image: {inputFileName}");

                outPath = TempFolder + "/" + resultFileName;

                // remove output file from the storage (if exists)
                if (this.ImagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
                }

                if (!this.ImagingApi.ObjectExists(new ObjectExistsRequest(inputPath, storage)).Exists.Value)
                {
                    this.ImagingApi.CopyFile(new CopyFileRequest(OriginalDataFolder + "/" + inputFileName,
                        folder + "/" + inputFileName, storage, storage));
                }

                this.ImagingApi.CopyFile(new CopyFileRequest(inputPath, outPath, storage, storage));
                Assert.IsTrue(this.ImagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value);

                var request = new PostTiffAppendRequest(resultFileName, inputFileName, storage, folder);
                ImagingApi.PostTiffAppend(request);

                StorageFile resultInfo = this.GetStorageFileInfo(folder, resultFileName, storage);
                if (resultInfo == null)
                {
                    throw new ArgumentException(
                        $"Result file {resultFileName} doesn't exist in the specified storage folder: {folder}. Result isn't present in the storage by an unknown reason.");
                }

                ImagingResponse resultProperties =
                    ImagingApi.GetImageProperties(new GetImagePropertiesRequest(resultFileName, folder, storage));
                Assert.NotNull(resultProperties);
                ImagingResponse originalProperties =
                    ImagingApi.GetImageProperties(new GetImagePropertiesRequest(inputFileName, folder, storage));
                Assert.NotNull(originalProperties);

                Assert.NotNull(resultProperties.TiffProperties);
                Assert.NotNull(originalProperties.TiffProperties);
                Assert.AreEqual(originalProperties.TiffProperties.Frames.Count * 2, resultProperties.TiffProperties.Frames.Count);
                Assert.AreEqual(originalProperties.Width, resultProperties.Width);
                Assert.AreEqual(originalProperties.Height, resultProperties.Height);

                passed = true;
            }
            catch (Exception ex)
            {
                FailedAnyTest = true;
                WriteLineEverywhere(ex.Message);
                throw;
            }
            finally
            {
                if (this.RemoveResult && this.ImagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
                {
                    this.ImagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
                }

                WriteLineEverywhere($"Test passed: {passed}");
            }
        }
    }
}
