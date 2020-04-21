// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ObjectDetectionTests.cs">
//  Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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

namespace Aspose.Imaging.Cloud.Sdk.Test.Api.AI
{
    using System.Web;
    using System.IO;
    using Client;
    using Model;
    using Model.Requests;
    using NUnit.Framework;
    using System.Linq;
    using System.Collections.Generic;
    using Aspose.Imaging.Cloud.Sdk.Test.Base;

    [TestFixture]
    public class ObjectDetectionTests : ImagingApiTester
    {
        private const string TestImage = "object_detection_example.jpg";

        [Test]
        public void ObjectBoundsTest()
        {
            var inputFile = InputTestFiles.FirstOrDefault(f=>string.Equals(f.Name, TestImage));
            var request = new ObjectBoundsRequest(inputFile.Name)
            {
                storage = TestStorage,
                folder = TempFolder,
                threshold = 60
            };

            using (var command = new ObjectDetectionTestCommand(
                request,
                ImagingApi,
                false,
                true,
                TempFolder,
                TestStorage,
                null))
            {
                ExecuteTestCommand(command, nameof(ObjectBoundsTest), $"Input image: {inputFile.Name};", inputFile.Name,
                    TempFolder, TestStorage);
            }
        }

        [Test]
        public void VisualObjectBoundsTest()
        {
            var inputFile = InputTestFiles.FirstOrDefault(f => string.Equals(f.Name, TestImage));
            var request = new VisualObjectBoundsRequest(inputFile.Name)
            {
                storage = TestStorage,
                folder = TempFolder,
                threshold = 60,
                includeClass = true,
                includeScore = true
            };

            using (var command = new VisualObjectDetectionTestCommand(
                request,
                ImagingApi,
                false,
                true,
                TempFolder,
                TestStorage,
                null))
            {
                ExecuteTestCommand(command, nameof(VisualObjectBoundsTest), $"Input image: {inputFile.Name};", inputFile.Name,
                    TempFolder, TestStorage);
            }
        }

        [TestCase(false)]
        [TestCase(true)]
        public void CreateObjectBoundsTest(bool saveResultToStorage)
        {
            var inputFile = InputTestFiles.FirstOrDefault(f => string.Equals(f.Name, TestImage));

            bool removeResult = true;
            using (var stream = ImagingApi.DownloadFile(new DownloadFileRequest(inputFile.Path)))
            {
                var request = new CreateObjectBoundsRequest()
                {
                    imageData = stream,
                    storage = TestStorage,
                    outPath = saveResultToStorage ? TempFolder + "/" + inputFile.Name : null,
                    threshold = 60,
                    includeClass = true,
                    includeScore = true
                };

                using (var command = new CreateObjectDetectionTestCommand(request, ImagingApi,
                    saveResultToStorage, removeResult))
                {
                    ExecuteTestCommand(command, nameof(CreateObjectBoundsTest), $"Input image: {inputFile.Name};", inputFile.Name,
                        TempFolder, TestStorage);
                }
            }
        }

        [TestCase(false)]
        [TestCase(true)]
        public void CreateVisualObjectBoundsTest(bool saveResultToStorage)
        {
            var inputFile = InputTestFiles.FirstOrDefault(f => string.Equals(f.Name, TestImage));

            bool removeResult = true;
            using (var stream = ImagingApi.DownloadFile(new DownloadFileRequest(inputFile.Path)))
            {
                var request = new CreateVisualObjectBoundsRequest()
                {
                    imageData = stream,
                    storage = TestStorage,
                    outPath = saveResultToStorage ? TempFolder + "/" + inputFile.Name : null,
                    threshold = 60,
                    includeClass = true,
                    includeScore = true
                };

                using (var command = new CreateVisualObjectDetectionTestCommand(request, ImagingApi,
                    saveResultToStorage, removeResult))
                {
                    ExecuteTestCommand(command, nameof(CreateVisualObjectBoundsTest), $"Input image: {inputFile.Name};", inputFile.Name,
                        TempFolder, TestStorage);
                }
            }
        }
    }
}