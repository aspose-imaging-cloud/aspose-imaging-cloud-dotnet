// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateModifiedSvgRequest.cs">
//   Copyright (c) 2018-2020 Aspose Pty Ltd. All rights reserved.
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
  /// Request model for <see cref="Aspose.Imaging.Cloud.Sdk.Api.ImagingApi.CreateModifiedSvg" /> operation.
  /// </summary>  
  public class CreateModifiedSvgRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModifiedSvgRequest"/> class.
        /// </summary>        
        public CreateModifiedSvgRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModifiedSvgRequest"/> class.
        /// </summary>
        /// <param name="imageData">Input image</param>
        /// <param name="colorType"></param>
        /// <param name="textAsShapes"></param>
        /// <param name="scaleX"></param>
        /// <param name="scaleY"></param>
        /// <param name="pageWidth"></param>
        /// <param name="pageHeight"></param>
        /// <param name="borderX"></param>
        /// <param name="borderY"></param>
        /// <param name="bkColor"></param>
        /// <param name="fromScratch"></param>
        /// <param name="outPath"></param>
        /// <param name="storage"></param>
        /// <param name="format"></param>
        public CreateModifiedSvgRequest(System.IO.Stream imageData, string colorType = null, bool? textAsShapes = null, double? scaleX = null, double? scaleY = null, int? pageWidth = null, int? pageHeight = null, int? borderX = null, int? borderY = null, string bkColor = null, bool? fromScratch = null, string outPath = null, string storage = null, string format = null)             
        {
            this.imageData = imageData;
            this.colorType = colorType;
            this.textAsShapes = textAsShapes;
            this.scaleX = scaleX;
            this.scaleY = scaleY;
            this.pageWidth = pageWidth;
            this.pageHeight = pageHeight;
            this.borderX = borderX;
            this.borderY = borderY;
            this.bkColor = bkColor;
            this.fromScratch = fromScratch;
            this.outPath = outPath;
            this.storage = storage;
            this.format = format;
        }
        
        /// <summary>
        /// Input image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }

        /// <summary>
        /// Gets or sets colorType
        /// </summary>  
        public string colorType { get; set; }

        /// <summary>
        /// Gets or sets textAsShapes
        /// </summary>  
        public bool? textAsShapes { get; set; }

        /// <summary>
        /// Gets or sets scaleX
        /// </summary>  
        public double? scaleX { get; set; }

        /// <summary>
        /// Gets or sets scaleY
        /// </summary>  
        public double? scaleY { get; set; }

        /// <summary>
        /// Gets or sets pageWidth
        /// </summary>  
        public int? pageWidth { get; set; }

        /// <summary>
        /// Gets or sets pageHeight
        /// </summary>  
        public int? pageHeight { get; set; }

        /// <summary>
        /// Gets or sets borderX
        /// </summary>  
        public int? borderX { get; set; }

        /// <summary>
        /// Gets or sets borderY
        /// </summary>  
        public int? borderY { get; set; }

        /// <summary>
        /// Gets or sets bkColor
        /// </summary>  
        public string bkColor { get; set; }

        /// <summary>
        /// Gets or sets fromScratch
        /// </summary>  
        public bool? fromScratch { get; set; }

        /// <summary>
        /// Gets or sets outPath
        /// </summary>  
        public string outPath { get; set; }

        /// <summary>
        /// Gets or sets storage
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Gets or sets format
        /// </summary>  
        public string format { get; set; }
  }
}
