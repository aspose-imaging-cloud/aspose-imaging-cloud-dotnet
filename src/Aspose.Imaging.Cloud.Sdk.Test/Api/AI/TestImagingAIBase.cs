// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestImagingAIBase.cs">
//  Copyright (c) 2018 Aspose Pty Ltd. All rights reserved.
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
    using System.Net;
    using System.Threading;
    using Model.Requests;
    using NUnit.Framework;
    using Storage.Cloud.Sdk.Model.Requests;

    public delegate void TestAction();

    [TestFixture]
    public abstract class TestImagingAIBase: ApiTester
    {
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

            if (this.StorageApi.GetIsExist(new GetIsExistRequest(TempFolder, null, DefaultStorage)).FileExist.IsExist.Value)
            {
                this.StorageApi.DeleteFolder(new DeleteFolderRequest(TempFolder, DefaultStorage, true));
            }
        }

        protected string SearchContextId { get; private set; }

        protected string OriginalDataFolder => "ImagingAI";

        protected string TempFolder => "TempImagingAI";

        protected string GetStoragePath(string imageName, string folder = null)
        {
            return Path.Combine(folder ?? this.OriginalDataFolder, imageName);
        }

        protected string CreateSearchContext()
        {
            var response = this.ImagingApi.PostCreateSearchContext(new PostCreateSearchContextRequest(storage: DefaultStorage));
            Assert.AreEqual(HttpStatusCode.OK, response.Code);
            return response.Id;
        }

        protected void DeleteSearchContext(string searchContextId)
        {
            this.ImagingApi.DeleteSearchContext(new DeleteSearchContextRequest(searchContextId, storage: DefaultStorage));
        }

        protected string GetSearchContextStatus(string searchContextId)
        {
            var response =  this.ImagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(this.SearchContextId, storage: DefaultStorage));
            Assert.AreEqual(HttpStatusCode.OK, response.Code);
            return response.SearchStatus;
        }

        protected void AddImageFeaturesToSearchContext(string storageSourcePath, bool isFolder = false)
        {
            var request = isFolder
                ? new PostSearchContextExtractImageFeaturesRequest(this.SearchContextId, imageId: null, imagesFolder: storageSourcePath, storage: DefaultStorage)
                : new PostSearchContextExtractImageFeaturesRequest(this.SearchContextId, imageId: storageSourcePath, storage: DefaultStorage);
            this.ImagingApi.PostSearchContextExtractImageFeatures(request);

            if (isFolder)
            {
                this.WaitSearchContextIdle(TimeSpan.FromMinutes(2));
            }
        }

        protected void WaitSearchContextIdle(TimeSpan maxTime)
        {
            var timeout = TimeSpan.FromSeconds(10);
            var spentTime = TimeSpan.Zero;

            while (this.ImagingApi.GetSearchContextStatus(new GetSearchContextStatusRequest(this.SearchContextId, storage: DefaultStorage)).SearchStatus != "Idle" && spentTime < maxTime)
            {
                Thread.Sleep(timeout);
                spentTime += timeout;
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            Console.WriteLine($"Test passed: {passed}");
        }
    }
}