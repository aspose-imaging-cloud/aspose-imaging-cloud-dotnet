// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostImageEmfRequest.cs">
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.ImagingApi.PostImageEmf" /> operation.
  /// </summary>  
  public class PostImageEmfRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageEmfRequest"/> class.
        /// </summary>        
        public PostImageEmfRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostImageEmfRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="bkColor">Color of the background.</param>
        /// <param name="pageWidth">Width of the page.</param>
        /// <param name="pageHeight">Height of the page.</param>
        /// <param name="borderX">Border width.</param>
        /// <param name="borderY">Border height.</param>
        /// <param name="fromScratch">Specifies where additional parameters we do not support should be taken from. If this is true – they will be taken from default values for standard image, if it is false – they will be saved from current image. Default is false.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed image).</param>
        public PostImageEmfRequest(System.IO.Stream imageData, string bkColor, int? pageWidth, int? pageHeight, int? borderX, int? borderY, bool? fromScratch = null, string outPath = null)             
        {
            this.imageData = imageData;
            this.bkColor = bkColor;
            this.pageWidth = pageWidth;
            this.pageHeight = pageHeight;
            this.borderX = borderX;
            this.borderY = borderY;
            this.fromScratch = fromScratch;
            this.outPath = outPath;
        }
		
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

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
  }
}
