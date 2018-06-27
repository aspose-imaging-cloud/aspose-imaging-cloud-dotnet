// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostImageTiffRequest.cs">
//   Copyright (c) 2018 Aspose Pty Ltd.
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.PostImageTiff" /> operation.
  /// </summary>  
  public class PostImageTiffRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageTiffRequest"/> class.
        /// </summary>        
        public PostImageTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageTiffRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="compression">Compression.</param>
        /// <param name="resolutionUnit">New resolution unit.</param>
        /// <param name="bitDepth">Bit depth.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="horizontalResolution">New horizontal resolution.</param>
        /// <param name="verticalResolution">New verstical resolution.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public PostImageTiffRequest(System.IO.Stream imageData, string compression, string resolutionUnit, int? bitDepth, bool? fromScratch = null, double? horizontalResolution = null, double? verticalResolution = null, string outPath = null, string storage = null)             
        {
            this.imageData = imageData;
            this.compression = compression;
            this.resolutionUnit = resolutionUnit;
            this.bitDepth = bitDepth;
            this.fromScratch = fromScratch;
            this.horizontalResolution = horizontalResolution;
            this.verticalResolution = verticalResolution;
            this.outPath = outPath;
            this.storage = storage;
        }
		
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Compression.
        /// </summary>  
        public string compression { get; set; }

        /// <summary>
        /// New resolution unit.
        /// </summary>  
        public string resolutionUnit { get; set; }

        /// <summary>
        /// Bit depth.
        /// </summary>  
        public int? bitDepth { get; set; }

        /// <summary>
        /// Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.
        /// </summary>  
        public bool? fromScratch { get; set; }

        /// <summary>
        /// New horizontal resolution.
        /// </summary>  
        public double? horizontalResolution { get; set; }

        /// <summary>
        /// New verstical resolution.
        /// </summary>  
        public double? verticalResolution { get; set; }

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
