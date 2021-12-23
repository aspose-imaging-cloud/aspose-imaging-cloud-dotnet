// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LoadCustomFontsTests.cs">
//   Copyright (c) 2018-2021 Aspose Pty Ltd. All rights reserved.
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

using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using System;
using System.IO;

namespace Aspose.Imaging.Cloud.Sdk.Test.Api
{
    [Category("v3.0")]
    [Category("CustomFonts")]
    [TestFixture]
    public class LoadCustomFontsTests : ImagingApiTester
    {
        protected override string OriginalDataFolder => base.OriginalDataFolder + "/UseCases";

        [Test]
        public void UsingCustomFontsForVectorImageTest()
        {   
            // custom fonts should be loaded to storage to 'Fonts' folder
            // 'Fonts' folder should be placed to the root of the cloud storage

            var imageName = "image.emz";
            var format = "png";
            string folder =this.TempFolder;
            string storage = this.TestStorage;

            this.TestGetRequest(
                        "UsingCustomFontsForVectorImageTest",
                        $"Input image: {imageName}; Output format: {format}",
                        imageName,
                        delegate
                        {
                            var request = new ConvertImageRequest(imageName, format, folder, storage);
                            var response = ImagingApi.ConvertImage(request);
                            Assert.That(Math.Abs(response.Length - 11454), Is.LessThan(100));
                            return response;
                        },
                        null,
                        folder,
                        storage);
        }
    }
}