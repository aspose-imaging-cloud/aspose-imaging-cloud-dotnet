﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="VisualObjectDetectionTestCommand.cs">
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
using System.IO;
using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Imaging.Cloud.Sdk.Test.Base
{
    public class VisualObjectDetectionTestCommand : ITestCommand
    {
        private readonly GetVisualObjectBoundsRequest request = null;
        private readonly ImagingApi imagingApi;
        private readonly bool saveResultToStorage;
        private readonly bool removeResult;
        private readonly string storage;
        private Stream response = null;
        private string outPath;
        private bool passed = false;

        public VisualObjectDetectionTestCommand(
            GetVisualObjectBoundsRequest request,
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
            response = imagingApi.GetVisualObjectBounds(request);
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
            Assert.IsTrue(response.Length > 0);
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
