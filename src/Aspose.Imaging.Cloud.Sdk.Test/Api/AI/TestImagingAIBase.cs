// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestImagingAIBase.cs">
//  Copyright (c) 2019 Aspose Pty Ltd. All rights reserved.
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
    using System;
    using System.IO;
    using System.Threading;
    using Model.Requests;
    using NUnit.Framework;

    [Category("AI")]
    [Category("v3.0")]
    [TestFixture]
    public abstract class TestImagingAIBase: ApiTester
    {
        public delegate void TestAction();

        private const int WaitTimeoutInMinutes = 5;

        protected string SearchContextId { get; private set; }

        protected override string CloudTestFolderPrefix => "ImagingAICloudTestDotNet";

        protected override string OriginalDataFolder => base.OriginalDataFolder + "/AI";

        [SetUp]
        public void InitTest()
        {
            this.SearchContextId = this.CreateSearchContext();
        }

        [TearDown]
        public void FinalizeTest()
        {
            if (!string.IsNullOrEmpty(this.SearchContextId))
            {
                this.DeleteSearchContext(this.SearchContextId);
            }

            if (this.ImagingApi.ObjectExists(new ObjectExistsRequest(TempFolder, this.TestStorage)).Exists.Value)
            {
                this.ImagingApi.DeleteFolder(new DeleteFolderRequest(TempFolder, this.TestStorage, true));
            }
        }

        protected string GetStoragePath(string imageName, string folder = null)
        {
            return Path.Combine(folder ?? this.OriginalDataFolder, imageName);
        }

        protected string CreateSearchContext()
        {
            var response = this.ImagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest(storage: this.TestStorage));
            return response.Id;
        }

        protected void DeleteSearchContext(string searchContextId)
        {
            this.ImagingApi.DeleteSearchContext(new DeleteSearchContextRequest(searchContextId, storage: this.TestStorage));
        }

        protected string GetSearchContextStatus(string searchContextId)
        {
            var response =  this.ImagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(searchContextId, storage: this.TestStorage));
            return response.SearchStatus;
        }

        protected void AddImageFeaturesToSearchContext(string storageSourcePath, bool isFolder = false)
        {
            var request = isFolder
                ? new PostSearchContextExtractImageFeaturesRequest(
                    this.SearchContextId, imageId: null, imagesFolder: storageSourcePath, storage: this.TestStorage)
                : new PostSearchContextExtractImageFeaturesRequest(this.SearchContextId, imageId: storageSourcePath, storage: this.TestStorage);
            this.ImagingApi.PostSearchContextExtractImageFeatures(request);


            this.WaitSearchContextIdle();
        }

        protected void WaitSearchContextIdle()
        {
            this.WaitSearchContextIdle(TimeSpan.FromMinutes(WaitTimeoutInMinutes));
        }

        protected void WaitSearchContextIdle(TimeSpan maxTime)
        {
            var timeout = TimeSpan.FromSeconds(10);
            var startTime = DateTime.UtcNow;

            while (this.ImagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(this.SearchContextId, storage: this.TestStorage)).
                SearchStatus != "Idle" && DateTime.UtcNow - startTime < maxTime)
            {
                Thread.Sleep(timeout);
            }
        }

        protected void RunTestWithLogging(string testMethodWithParams, TestAction testAction)
        {
            var passed = false;

            Console.WriteLine(testMethodWithParams);
            try
            {
                testAction();
                passed = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            Console.WriteLine($"Test passed: {passed}");
        }
    }
}