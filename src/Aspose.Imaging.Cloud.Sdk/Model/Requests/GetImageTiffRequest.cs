// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImageTiffRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.GetImageTiff" /> operation.
  /// </summary>  
  public class GetImageTiffRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageTiffRequest"/> class.
        /// </summary>        
        public GetImageTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageTiffRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of image.</param>
        /// <param name="compression">Compression.</param>
        /// <param name="resolutionUnit">New resolution unit.</param>
        /// <param name="bitDepth">Bit depth.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="horizontalResolution">New horizontal resolution.</param>
        /// <param name="verticalResolution">New verstical resolution.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public GetImageTiffRequest(string name, string compression, string resolutionUnit, int? bitDepth, bool? fromScratch = null, double? horizontalResolution = null, double? verticalResolution = null, string outPath = null, string folder = null, string storage = null)             
        {
            this.name = name;
            this.compression = compression;
            this.resolutionUnit = resolutionUnit;
            this.bitDepth = bitDepth;
            this.fromScratch = fromScratch;
            this.horizontalResolution = horizontalResolution;
            this.verticalResolution = verticalResolution;
            this.outPath = outPath;
            this.folder = folder;
            this.storage = storage;
        }
        
        /// <summary>
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

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
        /// Folder with image to process.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string storage { get; set; }
  }
}
