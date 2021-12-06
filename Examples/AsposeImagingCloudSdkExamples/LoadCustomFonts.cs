// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateJPEG2000Image.cs">
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

using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSdkExamples
{
    /// <summary>
    /// Load custom fonts example.
    /// </summary>
    internal class LoadCustomFonts : ImagingBase
    {
        private const string OutputImageFormat = "png";

        /// <summary>
        ///     Initializes a new instance of the <see cref="LoadCustomFonts" /> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public LoadCustomFonts(ImagingApi imagingApi) : base(imagingApi)
        {
            PrintHeader("Load custom fonts example:");
        }

        /// <summary>
        /// The sample image file name.
        /// </summary>
        protected override string SampleImageFileName => "ImageWithCustomFonts.emz";

        /// <summary>
        /// Using custom fonts for vector image conversion example.
        /// </summary>
        public void UsingCustomFontsForVectorImageConversion()
        {
            Console.WriteLine("Using custom fonts for vector image conversion");

            UploadSampleImageToCloud();

            // custom fonts should be loaded to storage to 'Fonts' folder
            // 'Fonts' folder should be placed to the root of the cloud storage
            UploadFontsToCloud();

            var folder = CloudPath; // Input file is saved at the Examples folder in the storage
            string storage = null; // Cloud Storage name
            var request = new ConvertImageRequest(SampleImageFileName, OutputImageFormat, folder, storage);

            Console.WriteLine($"Call Convert with params: format:{OutputImageFormat}");

            using (var updatedImage = ImagingApi.ConvertImage(request))
            {
                SaveUpdatedSampleImageToOutput(updatedImage, true, OutputImageFormat);
            }

            Console.WriteLine();
        }

        /// <summary>
        ///     Uploads custom fonts to cloud.
        /// </summary>
        protected void UploadFontsToCloud()
        {
            var fontsFolder = Path.Combine(ExampleImagesFolder, "Fonts");

            foreach (var fontFile in Directory.EnumerateFiles(fontsFolder, "*.ttf"))
            {
                using (var fontContent = File.OpenRead(fontFile))
                {
                    UploadToCloud(Path.Combine("Fonts", Path.GetFileName(fontFile)), fontContent);
                }
            }
        }

        /// <summary>
        ///     Uploads the file to cloud.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="fileContent">The file content.</param>
        private void UploadToCloud(string fileName, Stream fileContent)
        {
            var uploadFileRequest = new UploadFileRequest(fileName, fileContent);
            var result = ImagingApi.UploadFile(uploadFileRequest);
            Console.WriteLine(result.Errors?.Count > 0
                ? $"Uploading errors count: {result.Errors.Count}"
                : $"File {fileName} is uploaded to cloud storage");
        }
    }
}