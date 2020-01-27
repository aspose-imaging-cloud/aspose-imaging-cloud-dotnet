// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateResizedImageRequest.cs">
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

namespace Aspose.Imaging.Cloud.Sdk.Model.Requests 
{
  using Aspose.Imaging.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.CreateResizedImage" /> operation.
  /// </summary>  
  public class CreateResizedImageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResizedImageRequest"/> class.
        /// </summary>        
        public CreateResizedImageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResizedImageRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="newWidth">New width.</param>
        /// <param name="newHeight">New height.</param>
        /// <param name="format">Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public CreateResizedImageRequest(System.IO.Stream imageData, int? newWidth, int? newHeight, string format = null, string outPath = null, string storage = null)             
        {
            this.imageData = imageData;
            this.newWidth = newWidth;
            this.newHeight = newHeight;
            this.format = format;
            this.outPath = outPath;
            this.storage = storage;
        }
        
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// New width.
        /// </summary>  
        public int? newWidth { get; set; }

        /// <summary>
        /// New height.
        /// </summary>  
        public int? newHeight { get; set; }

        /// <summary>
        /// Resulting image format. Please, refer to https://docs.aspose.cloud/display/imagingcloud/Supported+File+Formats#SupportedFileFormats-CommonOperationsFormatSupportMap for possible use-cases.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Path to updated file (if this is empty, response contains streamed image).
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }
  }
}
