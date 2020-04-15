// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FramesApiTests.cs">
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
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Model;
    using Model.Requests;
    using NUnit.Framework;
    
    /// <summary>
    ///     Class for testing FramesApi
    /// </summary>
    [Category("v3.0")]
    [Category("Frames")]
    [TestFixture]
    public class FramesApiTests : ImagingApiTester
    {
        private readonly ICollection<string>
            _formatsWithoutProperties = new List<string>(new[] {".cdr", ".cmx", ".otg"});

        /// <summary>
        ///     Test GetImageFrame
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        [TestCase(".tiff")]
#if EXTENDED_TEST
        [TestCase(".cdr")]
        [TestCase(".cmx")]
        [TestCase(".dicom")]
        [TestCase(".djvu")]
        [TestCase(".gif")]
        [TestCase(".odg")]
        [TestCase(".otg")]
        [TestCase(".psd")]
        [TestCase(".webp")]
#endif
        public void GetImageFrameTest(string formatExtension)
        {
            var frameId = 1;
            var folder = TempFolder;
            var storage = TestStorage;
            var exportFormat = GetExportFormat(formatExtension, true);

            foreach (var inputFile in MultipageInputTestFiles)
            {
                var name = inputFile.Name;
                if (inputFile.Name.EndsWith(formatExtension))
                {
                }
                else
                {
                    continue;
                }

                TestGetRequest(
                    "GetImageFrameTest",
                    $"Input image: {name}; Frame id: {frameId}",
                    name,
                    delegate
                    {
                        var request = new GetImageFrameRequest(name, frameId, folder: folder, storage: storage);
                        return ImagingApi.GetImageFrame(request);
                    },
                    delegate(ImagingResponse properties, ImagingResponse resultProperties, Stream stream)
                    {
                        Assert.IsNotNull(resultProperties);
                        if (_formatsWithoutProperties.Contains(exportFormat))
                            return;

                        var propertiesName = GetPropertiesName(exportFormat);
                        var resultFormatProperties =
                            typeof(ImagingResponse)
                                .GetProperty(propertiesName, BindingFlags.Instance | BindingFlags.Public)
                                ?.GetValue(resultProperties, null);
                        Assert.IsNotNull(resultFormatProperties);
                    },
                    folder,
                    storage);
            }
        }

        /// <summary>
        ///     Test CreateImageFrame
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        [TestCase(".tiff", true)]
        [TestCase(".tiff", false)]
#if EXTENDED_TEST
        [TestCase(".cdr", true)]
        [TestCase(".cdr", false)]
        [TestCase(".cmx", true)]
        [TestCase(".cmx", false)]
        [TestCase(".dicom", true)]
        [TestCase(".dicom", false)]
        [TestCase(".djvu", true)]
        [TestCase(".djvu", false)]
        [TestCase(".gif", true)]
        [TestCase(".gif", false)]
        [TestCase(".odg", true)]
        [TestCase(".odg", false)]
        [TestCase(".otg", true)]
        [TestCase(".otg", false)]
        [TestCase(".psd", true)]
        [TestCase(".psd", false)]
        [TestCase(".webp", true)]
        [TestCase(".webp", false)]
#endif
        public void CreateImageFrameTest(string formatExtension, bool saveResultToStorage)
        {
            var frameId = 1;
            var folder = TempFolder;
            var storage = TestStorage;
            var exportFormat = GetExportFormat(formatExtension, true);

            foreach (var inputFile in MultipageInputTestFiles)
            {
                var name = inputFile.Name;
                if (inputFile.Name.EndsWith(formatExtension))
                {
                }
                else
                {
                    continue;
                }

                var outName = $"{name}_single_frame{exportFormat}";

                TestPostRequest(
                    "CreateImageFrameTest",
                    saveResultToStorage,
                    $"Input image: {name}; Frame id: {frameId}",
                    name,
                    outName,
                    delegate(Stream inputStream, string outPath)
                    {
                        var request =
                            new CreateImageFrameRequest(inputStream, frameId, outPath: outPath, storage: storage);
                        return ImagingApi.CreateImageFrame(request);
                    },
                    delegate(ImagingResponse properties, ImagingResponse resultProperties, Stream stream)
                    {
                        Assert.IsNotNull(resultProperties);
                        if (_formatsWithoutProperties.Contains(exportFormat))
                            return;

                        var propertiesName = GetPropertiesName(exportFormat);
                        var resultFormatProperties =
                            typeof(ImagingResponse)
                                .GetProperty(propertiesName, BindingFlags.Instance | BindingFlags.Public)
                                ?.GetValue(resultProperties, null);
                        Assert.IsNotNull(resultFormatProperties);
                    },
                    folder,
                    storage);
            }
        }

        /// <summary>
        ///     Test GetImageFrameRange
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        [TestCase(".tiff")]
#if EXTENDED_TEST
        [TestCase(".cdr")]
        [TestCase(".cmx")]
        [TestCase(".dicom")]
        [TestCase(".djvu")]
        [TestCase(".gif")]
        [TestCase(".odg")]
        [TestCase(".otg")]
        [TestCase(".psd")]
        [TestCase(".webp")]
#endif
        public void GetImageFrameRangeTest(string formatExtension)
        {
            var startFrameId = 0;
            var endFrameId = 1;
            var folder = TempFolder;
            var storage = TestStorage;
            var exportFormat = GetExportFormat(formatExtension, false);

            foreach (var inputFile in MultipageInputTestFiles)
            {
                var name = inputFile.Name;
                if (inputFile.Name.EndsWith(formatExtension))
                {
                }
                else
                {
                    continue;
                }

                TestGetRequest(
                    "GetImageFrameRangeTest",
                    $"Input image: {name}; Start frame id: {startFrameId}; End frame id: {endFrameId}",
                    name,
                    delegate
                    {
                        var request = new GetImageFrameRangeRequest(name, startFrameId, endFrameId, folder: folder,
                            storage: storage);
                        return ImagingApi.GetImageFrameRange(request);
                    },
                    delegate(ImagingResponse properties, ImagingResponse resultProperties, Stream stream)
                    {
                        Assert.IsNotNull(resultProperties);
                        if (_formatsWithoutProperties.Contains(exportFormat))
                            return;

                        var propertiesName = GetPropertiesName(exportFormat);
                        var resultFormatProperties =
                            typeof(ImagingResponse)
                                .GetProperty(propertiesName, BindingFlags.Instance | BindingFlags.Public)
                                ?.GetValue(resultProperties, null);
                        Assert.IsNotNull(resultFormatProperties);
                    },
                    folder,
                    storage);
            }
        }

        /// <summary>
        ///     Test CreateImageFrameRange
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        [TestCase(".tiff", true)]
        [TestCase(".tiff", false)]
#if EXTENDED_TEST
        [TestCase(".cdr", true)]
        [TestCase(".cdr", false)]
        [TestCase(".cmx", true)]
        [TestCase(".cmx", false)]
        [TestCase(".dicom", true)]
        [TestCase(".dicom", false)]
        [TestCase(".djvu", true)]
        [TestCase(".djvu", false)]
        [TestCase(".gif", true)]
        [TestCase(".gif", false)]
        [TestCase(".odg", true)]
        [TestCase(".odg", false)]
        [TestCase(".otg", true)]
        [TestCase(".otg", false)]
        [TestCase(".psd", true)]
        [TestCase(".psd", false)]
        [TestCase(".webp", true)]
        [TestCase(".webp", false)]
#endif
        public void CreateImageFrameRangeTest(string formatExtension, bool saveResultToStorage)
        {
            var startFrameId = 0;
            var endFrameId = 1;
            var folder = TempFolder;
            var storage = TestStorage;
            var exportFormat = GetExportFormat(formatExtension, false);

            foreach (var inputFile in MultipageInputTestFiles)
            {
                var name = inputFile.Name;
                if (inputFile.Name.EndsWith(formatExtension))
                {
                }
                else
                {
                    continue;
                }

                var outName = $"{name}_frame_range{exportFormat}";

                TestPostRequest(
                    "CreateImageFrameRangeTest",
                    saveResultToStorage,
                    $"Input image: {name}; Start frame id: {startFrameId}; End frame id: {endFrameId}",
                    name,
                    outName,
                    delegate(Stream inputStream, string outPath)
                    {
                        var request = new CreateImageFrameRangeRequest(inputStream, startFrameId, endFrameId,
                            outPath: outPath, storage: storage);
                        return ImagingApi.CreateImageFrameRange(request);
                    },
                    delegate(ImagingResponse properties, ImagingResponse resultProperties, Stream stream)
                    {
                        Assert.IsNotNull(resultProperties);
                        if (_formatsWithoutProperties.Contains(exportFormat))
                            return;

                        var propertiesName = GetPropertiesName(exportFormat);
                        var resultFormatProperties =
                            typeof(ImagingResponse)
                                .GetProperty(propertiesName, BindingFlags.Instance | BindingFlags.Public)
                                ?.GetValue(resultProperties, null);
                        Assert.IsNotNull(resultFormatProperties);
                    },
                    folder,
                    storage);
            }
        }

        /// <summary>
        ///     Test GetImageFrameProperties
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        [TestCase(".tiff")]
#if EXTENDED_TEST
        [TestCase(".cdr")]
        [TestCase(".cmx")]
        [TestCase(".dicom")]
        [TestCase(".djvu")]
        [TestCase(".gif")]
        [TestCase(".odg")]
        [TestCase(".otg")]
        [TestCase(".psd")]
        [TestCase(".webp")]
#endif
        public void TestGetFrameProperties(string formatExtension)
        {
            var frameId = 1;
            var folder = TempFolder;
            var storage = TestStorage;

            foreach (var inputFile in MultipageInputTestFiles)
            {
                var name = inputFile.Name;
                if (inputFile.Name.EndsWith(formatExtension))
                {
                }
                else
                {
                    continue;
                }

                CopyInputFileToTestFolder(name, folder, storage);

                WriteLineEverywhere("GetImageFrameProperties");
                WriteLineEverywhere($"Input image: {name}; Frame id: {frameId}");

                var responseMessage =
                    ImagingApi.GetImageFrameProperties(
                        new GetImageFramePropertiesRequest(name, frameId, folder, storage));

                Assert.IsNotNull(responseMessage);
                if (_formatsWithoutProperties.Contains(formatExtension))
                    continue;

                var propertiesName = GetPropertiesName(formatExtension);
                var resultFormatProperties =
                    typeof(ImagingResponse).GetProperty(propertiesName, BindingFlags.Instance | BindingFlags.Public)
                        ?.GetValue(responseMessage, null);
                Assert.IsNotNull(resultFormatProperties);
            }
        }

        /// <summary>
        ///     Test ExtractImageFrameProperties
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        [TestCase(".tiff")]
#if EXTENDED_TEST
        [TestCase(".cdr")]
        [TestCase(".cmx")]
        [TestCase(".dicom")]
        [TestCase(".djvu")]
        [TestCase(".gif")]
        [TestCase(".odg")]
        [TestCase(".otg")]
        [TestCase(".psd")]
        [TestCase(".webp")]
#endif
        public void TestExtractFrameProperties(string formatExtension)
        {
            var frameId = 1;
            var folder = TempFolder;
            var storage = TestStorage;

            foreach (var inputFile in MultipageInputTestFiles)
            {
                var name = inputFile.Name;
                if (inputFile.Name.EndsWith(formatExtension))
                {
                }
                else
                {
                    continue;
                }

                CopyInputFileToTestFolder(name, folder, storage);
                var imageData = ImagingApi.DownloadFile(new DownloadFileRequest(Path.Combine(folder, name), storage));

                WriteLineEverywhere("GetImageFrameProperties");
                WriteLineEverywhere($"Input image: {name}; Frame id: {frameId}");

                var responseMessage =
                    ImagingApi.ExtractImageFrameProperties(
                        new ExtractImageFramePropertiesRequest(imageData, frameId));

                Assert.IsNotNull(responseMessage);
                if (_formatsWithoutProperties.Contains(formatExtension))
                    continue;

                var propertiesName = GetPropertiesName(formatExtension);
                var resultFormatProperties =
                    typeof(ImagingResponse).GetProperty(propertiesName, BindingFlags.Instance | BindingFlags.Public)
                        ?.GetValue(responseMessage, null);
                Assert.IsNotNull(resultFormatProperties);
            }
        }

        /// <summary>
        ///     Get properties name for image format
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>Properties name</returns>
        private string GetPropertiesName(string format)
        {
            if (string.IsNullOrEmpty(format))
                throw new ArgumentNullException(nameof(format));

            if (format == ".jpg")
                format = ".jpeg";
            else if (format == ".j2k")
                format = ".jpeg2000";
            else if (format == ".webp")
                format = ".webP";

            format = format.TrimStart('.');

            return format.Substring(0, 1).ToUpperInvariant() + format.Substring(1) + "Properties";
        }

        /// <summary>
        ///     Get default export format
        /// </summary>
        /// <param name="format">Original image format</param>
        /// <param name="isSingleFrame">Is singleframe or multiframe operation</param>
        /// <returns></returns>
        private string GetExportFormat(string format, bool isSingleFrame)
        {
            if (new[] {".dicom", ".dng", ".djvu", ".cdr", ".cmx", ".odg", ".otg", ".svg"}.Contains(format))
                return isSingleFrame ? ".psd" : ".pdf";
            return format;
        }
    }
}
