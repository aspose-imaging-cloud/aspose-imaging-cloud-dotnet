// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ObjectDetectionTestCommand.cs">
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


using System.Collections.Generic;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using System.Linq;
using System;

namespace Aspose.Imaging.Cloud.Sdk.Test.Base
{
    public class ObjectDetectionTestCommand : ITestCommand
    {
        private readonly GetObjectBoundsRequest request = null;
        private readonly ImagingApi imagingApi;
        private readonly bool saveResultToStorage;
        private readonly bool removeResult;
        private readonly string storage;
        private DetectedObjectList response = null;
        private string outPath;
        private bool passed = false;

        public ObjectDetectionTestCommand(
            GetObjectBoundsRequest request,
            ImagingApi imagingApi,
            bool saveResultToStorage,
            bool removeResult,
            string folder,
            string storage,
            string resultFileName)
        {
            this.request = request;
            this.imagingApi = imagingApi;
            this.saveResultToStorage = saveResultToStorage;
            this.removeResult = removeResult;
            this.storage = storage;
            if(saveResultToStorage)
            {
                this.outPath = folder + "/" + resultFileName;
            }
        }

        public void InvokeRequest()
        {
            Prepare();
            response = imagingApi.GetObjectBounds(request);
        }

        private void Prepare()
        {
            if (saveResultToStorage)
            {
                // remove output file from the storage (if exists)
                if (imagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
                {
                   imagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
                }
            }
        }

        public void AssertResponse()
        {
            Assert.NotNull(response);
            Assert.NotNull(response.DetectedObjects);
            Assert.IsTrue(response.DetectedObjects.Count > 0);
            Assert.NotNull(response.DetectedObjects[0]);
            if (request.includeLabel == true)
            {
                Assert.NotNull(response.DetectedObjects[0].Label);
                if(!String.IsNullOrEmpty(request.allowedLabels))
                {
                    foreach(var label in request.allowedLabels.Split(',').Select(f=>f.Trim()))
                    {
                        foreach(var obj in response.DetectedObjects)
                        {
                            Assert.True(label.Equals(obj.Label, System.StringComparison.OrdinalIgnoreCase));
                        }
                    }
                }
                if (!string.IsNullOrEmpty(request.blockedLabels))
                {
                    foreach (var label in request.blockedLabels.Split(',').Select(f => f.Trim()))
                    {
                        foreach (var obj in response.DetectedObjects)
                        {
                            Assert.False(label.Equals(obj.Label, System.StringComparison.OrdinalIgnoreCase));
                        }
                    }
                }
            }
            else
            {
                Assert.Null(response.DetectedObjects[0].Label);
            }
            if (request.includeScore == true)
            {
                Assert.NotNull(response.DetectedObjects[0].Score);
            }
            else
            {
                Assert.Null(response.DetectedObjects[0].Score);
            }

            passed = true;
        }

        public void Dispose()
        {
            if (passed && saveResultToStorage && removeResult 
                && imagingApi.ObjectExists(new ObjectExistsRequest(outPath, storage)).Exists.Value)
            {
                imagingApi.DeleteFile(new DeleteFileRequest(outPath, storage));
            }
        }
    }
}
