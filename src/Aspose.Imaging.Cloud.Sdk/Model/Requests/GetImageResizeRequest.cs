// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImageResizeRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.GetImageResize" /> operation.
  /// </summary>  
  public class GetImageResizeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageResizeRequest"/> class.
        /// </summary>        
        public GetImageResizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageResizeRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of an image.</param>
        /// <param name="format">Resulting image format.</param>
        /// <param name="newWidth">New width.</param>
        /// <param name="newHeight">New height.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public GetImageResizeRequest(string name, string format, int? newWidth, int? newHeight, string outPath = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.format = format;
            this.newWidth = newWidth;
            this.newHeight = newHeight;
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
        /// New width.
        /// </summary>  
        public int? newWidth { get; set; }

        /// <summary>
        /// New height.
        /// </summary>  
        public int? newHeight { get; set; }

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
