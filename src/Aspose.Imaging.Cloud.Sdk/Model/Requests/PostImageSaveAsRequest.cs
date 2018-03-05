// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostImageSaveAsRequest.cs">
//   Copyright (c) 2018 Aspose.Imaging for Cloud
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.PostImageSaveAs" /> operation.
  /// </summary>  
  public class PostImageSaveAsRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageSaveAsRequest"/> class.
        /// </summary>        
        public PostImageSaveAsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageSaveAsRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="format">Resulting image format. Currently, BMP, PSD, JPG, TIFF, GIF, PNG, J2K and WEBP are supported.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        public PostImageSaveAsRequest(System.IO.Stream imageData, string format, string outPath = null)             
        {
            this.imageData = imageData;
            this.format = format;
            this.outPath = outPath;
        }
		
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Resulting image format. Currently, BMP, PSD, JPG, TIFF, GIF, PNG, J2K and WEBP are supported.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Path to updated file (if this is empty, response contains streamed image).
        /// </summary>  
        public string outPath { get; set; }
  }
}
