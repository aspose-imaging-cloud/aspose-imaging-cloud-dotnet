// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageApiTester.cs">
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
    using NUnit.Framework;

    /// <summary>
    /// Storage API tester.
    /// </summary>
    /// <seealso cref="Aspose.Imaging.Cloud.Sdk.Test.Api.ApiTester" />
    [Category("v3.0")]
    [Category("Storage")]
    [TestFixture]
    public class StorageApiTester : ApiTester
    {
        /// <summary>
        /// Original test data folder
        /// </summary>
        protected override string OriginalDataFolder => base.OriginalDataFolder + "/Storage";

        /// <summary>
        /// The cloud test folder prefix
        /// </summary>
        protected override string CloudTestFolderPrefix => "ImagingStorageCloudTestDotNet";
    }
}
