// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImageCropRequest.cs">
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

namespace Aspose.Imaging.Cloud.Sdk.Model.Requests 
{
  using Aspose.Imaging.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.GetImageCrop" /> operation.
  /// </summary>  
  public class GetImageCropRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageCropRequest"/> class.
        /// </summary>        
        public GetImageCropRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageCropRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of an image.</param>
        /// <param name="format">Resulting image format.</param>
        /// <param name="x">X position of start point for cropping rectangle.</param>
        /// <param name="y">Y position of start point for cropping rectangle.</param>
        /// <param name="width">Width of cropping rectangle</param>
        /// <param name="height">Height of cropping rectangle.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public GetImageCropRequest(string name, string format, int? x, int? y, int? width, int? height, string outPath = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.format = format;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.outPath = outPath;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Filename of an image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Resulting image format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// X position of start point for cropping rectangle.
        /// </summary>  
        public int? x { get; set; }

        /// <summary>
        /// Y position of start point for cropping rectangle.
        /// </summary>  
        public int? y { get; set; }

        /// <summary>
        /// Width of cropping rectangle
        /// </summary>  
        public int? width { get; set; }

        /// <summary>
        /// Height of cropping rectangle.
        /// </summary>  
        public int? height { get; set; }

        /// <summary>
        /// Path to updated file (if this is empty, response contains streamed image).
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// Folder with image to process.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }
  }
}
