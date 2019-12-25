// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ImagingBase.cs">
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

using Aspose.Imaging.Cloud.Sdk.Api;
using Aspose.Imaging.Cloud.Sdk.Model;
using Aspose.Imaging.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace AsposeImagingCloudSDKExamples
{
    /// <summary>
    /// Modify image example.
    /// </summary>
    abstract class ImagingBase
    {
        /// <summary>
        /// The example images folder path.
        /// </summary>
        public const string ExampleImagesFolder = @"..\..\..\..\Examples\Images";

        /// <summary>
        /// The output folder path.
        /// </summary>
        public const string OutputFolder = @"..\..\..\..\Examples\Output";

        /// <summary>
        /// The cloud path.
        /// </summary>
        protected const string CloudPath = "Examples";

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagingBase"/> class.
        /// </summary>
        /// <param name="imagingApi">The imaging API.</param>
        public ImagingBase(ImagingApi imagingApi)
        {
            this.ImagingApi = imagingApi;
        }

        /// <summary>
        /// Gets the imaging API.
        /// </summary>
        /// <value>
        /// The imaging API.
        /// </value>
        protected ImagingApi ImagingApi { get; private set; }

        /// <summary>
        /// Gets the name of the example image file.
        /// </summary>
        /// <value>
        /// The name of the example image file.
        /// </value>
        protected abstract string SampleImageFileName { get; }

        /// <summary>
        /// Gets the name of the modified sample image file.
        /// </summary>
        /// <param name="fromRequest">if set to <c>true</c> [created from request].</param>
        /// <param name="newFormatExtension">The new format extension.</param>
        /// <returns>The name of the modified sample image file.</returns>
        protected string GetModifiedSampleImageFileName(bool fromRequest = false, string newFormatExtension = null)
        {
            var nameWithNewExtension = newFormatExtension != null 
                ? Path.ChangeExtension(SampleImageFileName, newFormatExtension)
                : SampleImageFileName;
            return fromRequest
                ? $"ModifiedFromRequest{nameWithNewExtension}" 
                : $"Modified{nameWithNewExtension}";           
        }

        /// <summary>
        /// Uploads the example image to cloud.
        /// </summary>
        protected void UploadSampleImageToCloud()
        {
            using (FileStream localInputImage = File.OpenRead(Path.Combine(ExampleImagesFolder, SampleImageFileName)))
            {
                UploadImageToCloud(SampleImageFileName, localInputImage);
            }
        }

        /// <summary>
        /// Uploads the image to cloud.
        /// </summary>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="image">The image.</param>
        protected void UploadImageToCloud(string imageName, Stream image)
        {
            var uploadFileRequest = new UploadFileRequest(Path.Combine(CloudPath, imageName), image);
            FilesUploadResult result = ImagingApi.UploadFile(uploadFileRequest);
            if (result.Errors?.Count > 0)
            {
                Console.WriteLine($"Uploading erros count: {result.Errors.Count}");
            }
            else
            {
                Console.WriteLine($"Image {imageName} is uploaded to cloud storage");
            }
        }

        /// <summary>
        /// Saves the updated image to local output folder.
        /// </summary>
        /// <param name="updatedImage">The updated image.</param>
        protected void SaveUpdatedImageToOutput(Stream updatedImage, bool fromRequest, string newFormatExtension = null)
        {
            var newFileName = GetModifiedSampleImageFileName(fromRequest, newFormatExtension);

            SaveUpdatedImageToOutput(newFileName, updatedImage);
        }

        /// <summary>
        /// Saves the updated image to output folder.
        /// </summary>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="updatedImage">The updated image.</param>
        protected void SaveUpdatedImageToOutput(string imageName, Stream updatedImage)
        {
            var path = Path.GetFullPath(Path.Combine(OutputFolder, imageName));
            using (var fileStream = File.Create(path))
            {
                updatedImage.Seek(0, SeekOrigin.Begin);
                updatedImage.CopyTo(fileStream);
            }

            Console.WriteLine($"Image {imageName} is saved to {Path.GetDirectoryName(path)}");
        }

        /// <summary>
        /// Outputs the properties to file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="imagingResponse">The imaging response.</param>
        protected void OutputPropertiesToFile(string fileName, ImagingResponse imagingResponse)
        {
            var path = Path.GetFullPath(Path.Combine(OutputFolder, fileName));
            using (var fileStream = File.Create(path))
            {
                var writer = new StreamWriter(fileStream);
                writer.WriteLine($"Width: {imagingResponse.Width}");
                writer.WriteLine($"Height: {imagingResponse.Height}");
                writer.WriteLine($"Horizontal resolution: {imagingResponse.HorizontalResolution}");
                writer.WriteLine($"Vertical resolution: {imagingResponse.VerticalResolution}");
                writer.WriteLine($"Bits per pixel: {imagingResponse.BitsPerPixel}");

                if (imagingResponse.TiffProperties!=null)
                {
                    writer.WriteLine("Tiff properties:");

                    writer.WriteLine($"Frames count: {imagingResponse.TiffProperties.Frames.Count}");
                    writer.WriteLine($"Camera owner name: {imagingResponse.TiffProperties.ExifData?.CameraOwnerName}");
                    writer.WriteLine($"Byte order: {imagingResponse.TiffProperties.ByteOrder}");
                }
            }

            Console.WriteLine($"File {fileName} is saved to {Path.GetDirectoryName(path)}");
        }

        /// <summary>
        /// Prints the example header.
        /// </summary>
        /// <param name="header">The example header.</param>
        protected static void PrintHeader(string header)
        {
            Console.WriteLine(header);
            Console.WriteLine();
        }
    }
}