// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImageWmfRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.GetImageWmf" /> operation.
  /// </summary>  
  public class GetImageWmfRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageWmfRequest"/> class.
        /// </summary>        
        public GetImageWmfRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageWmfRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of image.</param>
        /// <param name="bkColor">Color of the background.</param>
        /// <param name="pageWidth">Width of the page.</param>
        /// <param name="pageHeight">Height of the page.</param>
        /// <param name="borderX">Border width.</param>
        /// <param name="borderY">Border height.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        /// <param name="folder">Folder with image to process.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        /// <param name="format">Export format (PNG is the default one).</param>
        public GetImageWmfRequest(string name, string bkColor, int? pageWidth, int? pageHeight, int? borderX, int? borderY, bool? fromScratch = null, string outPath = null, string folder = null, string storage = null, string format = null)             
        {
            this.name = name;
            this.bkColor = bkColor;
            this.pageWidth = pageWidth;
            this.pageHeight = pageHeight;
            this.borderX = borderX;
            this.borderY = borderY;
            this.fromScratch = fromScratch;
            this.outPath = outPath;
            this.folder = folder;
            this.storage = storage;
            this.format = format;
        }
        
        /// <summary>
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Color of the background.
        /// </summary>  
        public string bkColor { get; set; }

        /// <summary>
        /// Width of the page.
        /// </summary>  
        public int? pageWidth { get; set; }

        /// <summary>
        /// Height of the page.
        /// </summary>  
        public int? pageHeight { get; set; }

        /// <summary>
        /// Border width.
        /// </summary>  
        public int? borderX { get; set; }

        /// <summary>
        /// Border height.
        /// </summary>  
        public int? borderY { get; set; }

        /// <summary>
        /// Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.
        /// </summary>  
        public bool? fromScratch { get; set; }

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

        /// <summary>
        /// Export format (PNG is the default one).
        /// </summary>  
        public string format { get; set; }
  }
}
