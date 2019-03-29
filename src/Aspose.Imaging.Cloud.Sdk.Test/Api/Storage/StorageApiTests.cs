// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageApiTests.cs">
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

namespace Aspose.Imaging.Cloud.Sdk.Test.Api.Storage
{
    using System.Net;
    using Aspose.Imaging.Cloud.Sdk.Client;
    using Aspose.Imaging.Cloud.Sdk.Model.Requests;
    using NUnit.Framework;

    /// <summary>
    /// Specific Storage API tests.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Test.Api.Storage.StorageApiTester" />
    public class StorageApiTests : StorageApiTester
    {
        [Test]
        public void GetDiscUsageTest()
        {
            try
            {
                var discUsage = this.ImagingApi.GetDiscUsage(new GetDiscUsageRequest(this.TestStorage));
                Assert.Less(discUsage.UsedSize, discUsage.TotalSize);
                Assert.Greater(discUsage.TotalSize, 0);
                Assert.Greater(discUsage.UsedSize, 0);
            }
            catch (ApiException ex)
            {
                Assert.IsTrue(ex.ErrorCode == (int)HttpStatusCode.NotImplemented);
            }
        }

        [Test]
        public void StorageExistsTest()
        {
            var storageExists = this.ImagingApi.StorageExists(new StorageExistsRequest(this.TestStorage));
            Assert.IsTrue(storageExists.Exists.Value);
        }

        [Test]
        public void StorageDoesNotExistTest()
        {
            var storageExists = this.ImagingApi.StorageExists(new StorageExistsRequest("NotExistingStorage"));
            Assert.IsFalse(storageExists.Exists.Value);
        }
    }
}
